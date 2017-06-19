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
    public partial class login_form : Form
    {
        MySqlConnection connect;
        public bool is_login = false;
        public int role_id;
        public int user_id;
        public string LastName, FirstName, Patronymic;
        public login_form(MySqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (common.check_textbox(tb_tabl_num, "Введите табельный номер!", "Внимание"))
                return;

            if (common.check_textbox(tb_password, "Введите пароль!", "Внимание"))
                return;

            string commandtext = string.Format("select * from users where login = '{0}' and password = '{1}'", tb_tabl_num.Text, tb_password.Text);
                        common.open_connect(connect);
            MySqlCommand command = new MySqlCommand(commandtext, connect);
            MySqlDataReader data = command.ExecuteReader();
            if (data.Read())
            {
                user_id = data.GetInt32("id");
                role_id = data.GetInt32("role_id");
                LastName = data.GetString("last_name");
                FirstName = data.GetString("name");
                Patronymic = data.GetString("patronymic");
                is_login = true;
                            common.close_connect(connect);
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный табельный номер и/или пароль!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_password.Text = "";
            }
                        common.close_connect(connect);
            data.Close();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            tb_tabl_num.Focus();
        }
    }
}
