using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ARM_medacc
{
    public partial class main_form : Form
    {
        MySqlConnection connect;
        int role_id;
        public int user_id;
        public main_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("config.cfg"))
            {
                MessageBox.Show("Отсутствует файл конфигурации!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            MySqlConnectionStringBuilder connect_builder = new MySqlConnectionStringBuilder();
            using (StreamReader sr = new StreamReader("config.cfg"))
            {
                connect_builder.Server = sr.ReadLine();
                connect_builder.Database = sr.ReadLine();
                connect_builder.UserID = sr.ReadLine();
                connect_builder.Password = sr.ReadLine();
            }
            connect_builder.CharacterSet = "utf8";
            connect = new MySqlConnection(connect_builder.GetConnectionString(true));
                        common.open_connect(connect);
            if (connect.State != ConnectionState.Open)
            {
                MessageBox.Show("Ошибка подключения к базе данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
                        common.close_connect(connect);

            login_form login_frm = new login_form(connect);
            login_frm.ShowDialog();
            if (!login_frm.is_login)
            {
                Close();
                return;
            }

            user_id = login_frm.user_id;
            role_id = login_frm.role_id;
            string role_description = "unknown";
            switch (role_id)
            {
                case 1:
                    role_description = "Администратор";
                    admin();
                    break;
                case 2:
                    role_description = "Материально ответственное лицо";
                    frp();
                    break;
                case 3:
                    role_description = "Бухгалтер";
                    accountant();
                    break;
                default:
                    role_description = "unknown";
                    hide_all();
                    break;
            }
            Text += string.Format("[{0} {1} {2}, {3}]", login_frm.LastName, login_frm.FirstName, login_frm.Patronymic, role_description);
            label_fio.Text = string.Format("{0} {1}.{2}.", login_frm.LastName, login_frm.FirstName[0], login_frm.Patronymic[0]);
        }

        private void hide_all()
        {
            foreach (Control cur in flp.Controls)
                cur.Hide();
        }
        private void admin()
        {
            hide_all();

            bt_create_user.Show();
            bt_delete_user.Show();
            bt_grant.Show();
        }

        private void accountant()
        {
            hide_all();

            bt_register.Show();
            bt_unregister.Show();
            bt_appoint.Show();
            bt_report.Show();
            but_confirm_request.Show();
        }

        private void frp() //financially responsible person
        {
            hide_all();

            bt_show_materials.Show();
            bt_create_request.Show();
            bt_edit_request.Show();
        }

        private void bt_create_user_Click(object sender, EventArgs e)
        {
            create_user frm = new create_user(connect);
            frm.ShowDialog();
        }

        private void bt_grant_Click(object sender, EventArgs e)
        {
            assign_permissions frm = new assign_permissions(connect);
            frm.ShowDialog();
        }

        private void bt_delete_user_Click(object sender, EventArgs e)
        {
            delete_user frm = new delete_user(connect);
            frm.ShowDialog();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_unregister_Click(object sender, EventArgs e)
        {

        }

        private void bt_appoint_Click(object sender, EventArgs e)
        {
            appoint_frm frm = new appoint_frm(connect);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void bt_create_request_Click(object sender, EventArgs e)
        {
            create_request frm = new create_request(connect);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void bt_edit_request_Click(object sender, EventArgs e)
        {
            correct_request frm = new correct_request(connect);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void bt_show_materials_Click(object sender, EventArgs e)
        {
            show_materials_mol frm = new show_materials_mol(connect);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void but_confirm_request_Click(object sender, EventArgs e)
        {
            select_confirm_request frm = new select_confirm_request(connect);
            frm.Owner = this;
            frm.ShowDialog();
  
        }
    }
}
