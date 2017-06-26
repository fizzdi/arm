using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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
                dgv_table.Rows[i].Cells[col_count.Index].Value = data.GetInt32("amount");
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
                tb_mol.Text = string.Format("{0} {1} {2}", data.GetString("last_name"), data.GetString("name"), data.GetString("patronymic"));
            }
            data.Close();
            common.close_connect(connect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(String.Format("Внимание, данные материалы будут {0}. Продолжить?", rb_type_get.Checked ? "списаны" : "поставлены на учет"), "Внимание", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            MySqlCommand command = new MySqlCommand("update requests set status = 1 where code = " + req, connect);
            common.open_connect(connect);
            command.ExecuteNonQuery();

            command.CommandText = "select * from temp_materials where request = " + req + " order by id";
            MySqlDataReader tmater = command.ExecuteReader();
            List<List<string>> maters = new List<List<string>>();
            while (tmater.Read())
            {
                List<string> tmp = new List<string>();
                tmp.Add(tmater.GetString("description"));
                tmp.Add(tmater.GetString("measure"));
                tmp.Add(tmater.GetString("region"));
                tmp.Add(tmater.GetString("amount"));
                maters.Add(tmp);
            }
            tmater.Close();

            File.Copy(Path.GetFullPath("templates\\akt.xls"), Path.GetFullPath(string.Format("АКТ №{0:00000000}.xls", req)));
            Excel.Application exap = new Excel.Application();
            exap.Workbooks.Open(Path.GetFullPath(string.Format("АКТ №{0:00000000}.xls", req)));
            Excel.Worksheet exsh = exap.Worksheets[1];
            exsh.Cells[7, 10] = string.Format("АКТ №{0:00000000}", req);
            exsh.Cells[9, 10] = "от " + DateTime.Now.ToString("dd MMMM yyyy") + " г.";
            exsh.Cells[9, 62] = DateTime.Now.ToString("dd.MM.yyyy");
            exsh.Cells[13, 11] = tb_mol.Text;


            //Формирование акта на списание
            if (rb_type_get.Checked)
                exsh.Cells[8, 10] = "О СПИСАНИИ МАТЕРИАЛЬНЫХ ЗАПАСОВ";
            else
                exsh.Cells[8, 10] = "О ПРИЕМКЕ МАТЕРИАЛЬНЫХ ЗАПАСОВ";

            try {

                for (int i = maters.Count - 1; i >=0; --i)
                {
                    if (i != maters.Count - 1)
                        common.dublicate_row(24, exsh);

                    string descr = maters[i][0];
                    string meas = maters[i][1];
                    string region = maters[i][2];
                    string amount = maters[i][3];

                    exsh.Cells[24, 1] = i+1;
                    exsh.Cells[24, 3] = descr;
                    exsh.Cells[24, 18] = meas;
                    exsh.Cells[24, 22] = amount;
                    exsh.Cells[24, 26] = region;

                    MySqlCommand com = new MySqlCommand(string.Format("update materials set amount = amount{0}{1} where description = '{2}' and measure = '{3}' and region = '{4}' and frp = '{5}'",
                        (rb_type_set.Checked ? "+" : "-"), amount, descr, meas, region, frp), connect);
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
            }
            catch (Exception ex)
            {
                exap.ActiveWorkbook.Close(false);
                exap.Quit();
                return;
            }

            MessageBox.Show("Заявка #" + req + " утверждена!");

           

           



            exap.Visible = true;
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

        //rpivate
    }
}
