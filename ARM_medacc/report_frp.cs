using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace ARM_medacc
{
    public partial class report_frp : Form
    {
        MySqlConnection connect;
        public report_frp(MySqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;

            common.open_connect(connect);
            List<string> mols = new List<string>();
            MySqlCommand molcommand = new MySqlCommand("select id, concat(last_name, ' ', name, ' ', patronymic) as mol from users where role_id = 2", connect);
            MySqlDataReader molread = molcommand.ExecuteReader();

            while (molread.Read())
                mols.Add(molread.GetString("mol"));
            molread.Close();
            common.close_connect(connect);
            cb_frp.Items.AddRange(mols.ToArray());
            cb_frp.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frp`= (select id from users where concat(last_name, ' ', name, ' ', patronymic) = '{0}' limit 1) 
            string commandtext = "select num from `config` order by id desc limit 1";
            common.open_connect(connect);
            MySqlCommand command = new MySqlCommand(commandtext, connect);
            int req = (int)command.ExecuteScalar();

            File.Copy(Path.GetFullPath("templates\\mol.xls"), Path.GetFullPath(string.Format("ОТЧЕТ №{0:00000000}.xls", req)));
            Excel.Application exap = new Excel.Application();
            exap.Workbooks.Open(Path.GetFullPath(string.Format("ОТЧЕТ №{0:00000000}.xls", req)));
            Excel.Worksheet exsh = exap.Worksheets[1];
            exsh.Cells[7, 10] = string.Format("ОТЧЕТ №{0:00000000}", req);
            exsh.Cells[9, 10] = "от " + DateTime.Now.ToString("dd MMMM yyyy") + " г.";
            exsh.Cells[9, 62] = DateTime.Now.ToString("dd.MM.yyyy");
            exsh.Cells[13, 11] = cb_frp.Text;

            command.CommandText = "SELECT description, amount, measure, region, us.frp as frp FROM `materials` LEFT JOIN (SELECT id, CONCAT(last_name, ' ', name, ' ', patronymic) frp FROM users) us ON us.id = materials.frp WHERE amount >0 and us.frp = '" + cb_frp.Text+"'";

            MySqlDataReader data = command.ExecuteReader();
            var source = new AutoCompleteStringCollection();
            int i = 0;
            while (data.Read())
            {
                if (i != 0)
                    common.dublicate_row(20, exsh);
                exsh.Cells[20, 1] = i + 1;
                exsh.Cells[20, 3] = data.GetString("description");
                exsh.Cells[20, 18] = data.GetString("measure");
                exsh.Cells[20, 22] = data.GetString("amount");
                exsh.Cells[20, 26] = data.GetString("region");
                i++;
            }

            while (i-- > 0)
                exsh.Cells[20 + i, 1] = i + 1;
            data.Close();
            command.CommandText = "update `config` set num = num + 1";
            command.ExecuteNonQuery();
            exap.Visible = true;
            common.close_connect(connect);
        }
    }
}
