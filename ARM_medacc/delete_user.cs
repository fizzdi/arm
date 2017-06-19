using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_medacc
{
    public partial class delete_user : Form
    {
        MySqlConnection connect;
        bool flag = false;
        public delete_user(MySqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
            init();
        }

        private void init()
        {
            cb_fio.SelectedIndex = -1;
            cb_tabnum.SelectedIndex = -1;
            cb_fio.Items.Clear();
            cb_tabnum.Items.Clear();
                        common.open_connect(connect);
            MySqlCommand mycommand = new MySqlCommand("select * from users", connect);
            MySqlDataReader rd = mycommand.ExecuteReader();
            while (rd.Read())
            {
                cb_fio.Items.Add(string.Format("{0} {1} {2}", rd.GetString("last_name"), rd.GetString("name"), rd.GetString("patronymic")));
                cb_tabnum.Items.Add(rd.GetString("login"));
            }
            rd.Close();
                        common.close_connect(connect);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (cb_fio.SelectedIndex == -1 || cb_tabnum.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран пользователь!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                        common.open_connect(connect);
            var strs = (cb_fio.SelectedItem as string).Split(' ');
            MySqlCommand mycommand = new MySqlCommand(string.Format("delete from users where login = '{0}'", cb_tabnum.SelectedItem), connect);
            mycommand.ExecuteNonQuery();
                        common.close_connect(connect);
            MessageBox.Show("Удалено!", "Удалено!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            init();
        }

        private void cb_tabnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tabnum.SelectedIndex == -1 || flag)
                return;
                        common.open_connect(connect);
            MySqlCommand mycommand = new MySqlCommand(string.Format("select * from users where login = '{0}'", cb_tabnum.SelectedItem), connect);
            MySqlDataReader rd = mycommand.ExecuteReader();
            if (!rd.HasRows)
            {
                MessageBox.Show("Не существует пользователя с таким табельным номером!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rd.Read())
            {
                flag = true;
                cb_fio.SelectedItem = string.Format("{0} {1} {2}", rd.GetString("last_name"), rd.GetString("name"), rd.GetString("patronymic"));
                flag = false;
            }
            rd.Close();
                        common.close_connect(connect);
        }

        private void cb_fio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_fio.SelectedIndex == -1 || flag)
                return;
                        common.open_connect(connect);
            var strs = (cb_fio.SelectedItem as string).Split(' ');
            MySqlCommand mycommand = new MySqlCommand(string.Format("select * from users where last_name = '{0}' and name = '{1}' and patronymic = '{2}'", strs[0], strs[1], strs[2]), connect);
            MySqlDataReader rd = mycommand.ExecuteReader();
            if (!rd.HasRows)
            {
                MessageBox.Show("Не существует пользователя с таким табельным номером!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (rd.Read())
            {
                flag = true;
                cb_tabnum.SelectedItem = rd.GetString("login");
                flag = false;
            }
            rd.Close();
                        common.close_connect(connect);
        }
    }
}
