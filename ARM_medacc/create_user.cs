using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ARM_medacc
{
    public partial class create_user : Form
    {
        MySqlConnection connect;
        public create_user(MySqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
            cb_grant.SelectedIndex = 0;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (common.check_textbox(tb_tablnum, "Введите табельный номер!", "Внимание"))
                return;

            if (common.check_textbox(tb_password, "Введите пароль!", "Внимание"))
                return;

            if (common.check_textbox(tb_lastname, "Введите фамилию!", "Внимание"))
                return;

            if (common.check_textbox(tb_name, "Введите имя!", "Внимание"))
                return;

            if (common.check_textbox(tb_patronymic, "Введите отчество!", "Внимание"))
                return;

                        common.open_connect(connect);
            MySqlCommand mycommand = new MySqlCommand(string.Format("select * from users where login = '{0}'", tb_tablnum.Text), connect);
            MySqlDataReader rd = mycommand.ExecuteReader();
            if (rd.HasRows)
            {
                MessageBox.Show("Пользователь с таким табельным номером уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_tablnum.Focus();
                            common.close_connect(connect);
                rd.Close();
                return;
            }
            rd.Close();


            string txtcommand = string.Format("insert into `users` (`login`, `password`, `last_name`, `name`, `patronymic`, `role_id`) values ('{0}', '{1}', '{2}', '{3}', '{4}', {5})",
                tb_tablnum.Text, tb_password.Text, tb_lastname.Text, tb_name.Text, tb_patronymic.Text, cb_grant.SelectedIndex + 1);
            mycommand.CommandText = txtcommand;
            mycommand.ExecuteNonQuery();
                        common.close_connect(connect);
            Close();
        }
    }
}
