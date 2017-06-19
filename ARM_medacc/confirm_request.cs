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
    public partial class confirm_request : Form
    {
        MySqlConnection connect;
        int req = 0;
        int frp = -1;
        public confirm_request(MySqlConnection connect, int req)
        {
            InitializeComponent();
            this.connect = connect;
            this.req = req;
        }


        private void confirm_request_Load(object sender, EventArgs e)
        {
            string commandtext = "select * from `temp_materials` where request = " + req;
            common.open_connect(connect);
            MySqlCommand command = new MySqlCommand(commandtext, connect);
            MySqlDataReader data = command.ExecuteReader();
            var source = new AutoCompleteStringCollection();
            int i = 0;
            while (data.Read())
            {
                dgv_table.Rows.Add();
                dgv_table.Rows[i].Cells[col_material.Index].Value = data.GetString("description");
                dgv_table.Rows[i].Cells[col_count.Index].Value = data.GetString("amount");
                dgv_table.Rows[i].Cells[col_region.Index].Value = data.GetString("region");
                dgv_table.Rows[i].Cells[col_measure.Index].Value = data.GetString("measure");
                i++;
            }
            data.Close();
            command.CommandText = "select * from requests where code = " + req;
            data = command.ExecuteReader();
            if (data.Read())
            {
                frp = data.GetInt32("frp");
                if (data.GetInt32("type") == 0)
                    rb_type_set.Checked = true;
                else rb_type_get.Checked = true;
            }
            data.Close();

            command.CommandText = "select * from users where id = " + frp;
            data = command.ExecuteReader();
            if (data.Read())
            {
                tb_mol.Text = data.GetString("last_name");
                string name = data.GetString("name");
                string patronymic = data.GetString("patronymic");
                if (name.Length > 0)
                {
                    tb_mol.Text += " " + name[0] + ".";
                    if (patronymic.Length > 0)
                        tb_mol.Text += " " + patronymic[0] + ".";
                }
            }
            data.Close();
            common.close_connect(connect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("update requests set status = 1 where code = " + req, connect);
            common.open_connect(connect);
            command.ExecuteNonQuery();
            MessageBox.Show("Заявка #" + req + " утверждена!");

            command.CommandText = "select * from temp_materials where request = " + req;
            MySqlDataReader tmater = command.ExecuteReader();
            List<List<string>> maters = new List<List<string>>();
            while (tmater.Read())
            {
                List<string> tmp = new List<string>();
                tmp.Add(tmater.GetString("description"));
                tmp.Add(tmater.GetString("measure"));
                tmp.Add(tmater.GetString("region"));
                maters.Add(tmp);
            }
            tmater.Close();
            for (int i = 0; i < maters.Count; ++i)
            {
                string descr = maters[i][0];
                string meas = maters[i][1];
                string region = maters[i][2];
                MySqlCommand com = new MySqlCommand(string.Format("update materials set amount = amount{0}{1} where descripton = '{2}' and measure = '{3}' and region = '{4}'",
                    (rb_type_get.Checked ? "+" : "-"), tmater.GetInt32("amount"), descr, meas, region), connect);
                if (com.ExecuteNonQuery() == 0)
                {
                    com.CommandText = string.Format(
                        "INSERT INTO `materials`(`description`, `measure`, `amount`, `region`, `frp`, `request`) select description, measure, amount, region, frp, request from temp_materials where request = '{0}' and frp = {1} and region = '{2}' and measure = '{3}' and description = '{4}'", req, frp, region, meas, descr);
                    com.ExecuteNonQuery();
                }
                com.CommandText = string.Format("delete from temp_materials where request = '{0}' and frp = {1} and region = '{2}' and measure = '{3}' and description = '{4}'", req, frp, region, meas, descr);
                com.ExecuteNonQuery();
            }
            common.close_connect(connect);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("update requests set status = 2 where code = " + req, connect);
            common.open_connect(connect);
            command.ExecuteNonQuery();
            MessageBox.Show("Заявка #" + req + " отклонена!");
            common.close_connect(connect);
            Close();
        }
    }
}
