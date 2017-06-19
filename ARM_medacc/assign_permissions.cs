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
    public partial class assign_permissions : Form
    {
        MySqlConnection connect;
        bool flag = false;
        public assign_permissions(MySqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void assign_permissions_Load(object sender, EventArgs e)
        {
            connect.Open();
            MySqlCommand mycommand = new MySqlCommand("select * from users", connect);
            MySqlDataReader rd = mycommand.ExecuteReader();
            while (rd.Read())
            {
                cb_fio.Items.Add(string.Format("{0} {1} {2}", rd.GetString("last_name"), rd.GetString("name"), rd.GetString("patronymic")));
                cb_tabnum.Items.Add(rd.GetString("login"));
            }
            rd.Close();
            connect.Close();
        }

        private void cb_tabnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tabnum.SelectedIndex == -1 || flag)
                return;
            connect.Open();
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
                cb_grant.SelectedIndex = rd.GetInt32("role_id")-1;
                flag = false;
            }
            rd.Close();
            connect.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (cb_fio.SelectedIndex == -1 || cb_tabnum.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран пользователь!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            connect.Open();
            var strs = (cb_fio.SelectedItem as string).Split(' ');
            MySqlCommand mycommand = new MySqlCommand(string.Format("update users set role_id = {0} where login = '{1}'", cb_grant.SelectedIndex + 1, cb_tabnum.SelectedItem), connect);
            mycommand.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Сохранено!", "Сохранено!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void cb_fio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_fio.SelectedIndex == -1 || flag)
                return;
            connect.Open();
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
                cb_grant.SelectedIndex = rd.GetInt32("role_id") - 1;
                flag = false;
            }
            rd.Close();
            connect.Close();
        }
    }
}
