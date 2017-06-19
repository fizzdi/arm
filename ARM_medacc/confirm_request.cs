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
        public confirm_request(MySqlConnection connect, int req)
        {
            InitializeComponent();
            this.connect = connect;
            this.req = req;
        }


        private void confirm_request_Load(object sender, EventArgs e)
        {
            string commandtext = "select * from `temp_materials` where request = " + req;
            connect.Open();
            MySqlCommand command = new MySqlCommand(commandtext, connect);
            MySqlDataReader data = command.ExecuteReader();
            var source = new AutoCompleteStringCollection();
            int i = 0;
            int frp = -1;
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
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("update requests set status = 1 where code = " + req, connect);
            connect.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Заявка #" + req + " утверждена!");

            //обработка материалов
            command.CommandText = "select * from temp_materials where request = " + req;
            MySqlDataReader tmater = command.ExecuteReader();
            string insertcommand = "insert into materials (description, measure, amount, region, ftp, request) values (";
            string updatecommand = "update materials set ";

            int ins = 0;
            int upd = 0;
            while (tmater.Read())
            {

            }

            insertcommand += ")";
            updatecommand += " where ";

            connect.Close();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("update requests set status = 2 where code = " + req, connect);
            connect.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Заявка #" + req + " отклонена!");
            connect.Close();
            Close();
        }
    }
}
