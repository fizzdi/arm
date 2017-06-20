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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace ARM_medacc
{
    public partial class reports : Form
    {
        MySqlConnection connect;
        public reports(MySqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }
       
        // command.CommandText = "SELECT description, region, measure, SUM(amount)AS amount FROM  `materials` GROUP BY description, region, measure ORDER BY description DESC ";

        private void generate_main_report(string NameReport, bool check = false)
        {
            string commandtext = "select num from `config` order by id desc limit 1";
            common.open_connect(connect);
            MySqlCommand command = new MySqlCommand(commandtext, connect);
            int req = (int)command.ExecuteScalar();

            File.Copy(Path.GetFullPath("templates\\all.xls"), Path.GetFullPath(string.Format("ОТЧЕТ №{0:00000000}.xls", req)));
            Excel.Application exap = new Excel.Application();
            exap.Workbooks.Open(Path.GetFullPath(string.Format("ОТЧЕТ №{0:00000000}.xls", req)));
            Excel.Worksheet exsh = exap.Worksheets[1];
            exsh.Cells[7, 10] = string.Format("ОТЧЕТ №{0:00000000}", req);
            exsh.Cells[9, 10] = "от " + DateTime.Now.ToString("dd MMMM yyyy") + " г.";
            exsh.Cells[9, 62] = DateTime.Now.ToString("dd.MM.yyyy");
            exsh.Cells[8, 10] = NameReport;

            command.CommandText = string.Format("SELECT description, region, measure, SUM(amount)AS amount FROM  `materials` GROUP BY description, region, measure {0}ORDER BY description DESC", 
                (check ? "HAVING amount > 0 " : ""));

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
                exsh.Cells[20, 27] = data.GetString("region");
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

        private void generate_mol_report(string NameReport, bool check = false)
        {
            string commandtext = "select num from `config` order by id desc limit 1";
            common.open_connect(connect);
            MySqlCommand command = new MySqlCommand(commandtext, connect);
            int req = (int)command.ExecuteScalar();

            File.Copy(Path.GetFullPath("templates\\all_mol.xls"), Path.GetFullPath(string.Format("ОТЧЕТ №{0:00000000}.xls", req)));
            Excel.Application exap = new Excel.Application();
            exap.Workbooks.Open(Path.GetFullPath(string.Format("ОТЧЕТ №{0:00000000}.xls", req)));
            Excel.Worksheet exsh = exap.Worksheets[1];
            exsh.Cells[7, 10] = string.Format("ОТЧЕТ №{0:00000000}", req);
            exsh.Cells[9, 10] = "от " + DateTime.Now.ToString("dd MMMM yyyy") + " г.";
            exsh.Cells[9, 62] = DateTime.Now.ToString("dd.MM.yyyy");
            exsh.Cells[8, 10] = NameReport;

            command.CommandText = "SELECT description, amount, measure, region, us.frp as frp FROM `materials` LEFT JOIN (SELECT id, CONCAT(last_name, ' ', name, ' ', patronymic) frp FROM users) us ON us.id = materials.frp";
            if (check)
                command.CommandText += " WHERE amount >0";

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
                exsh.Cells[20, 27] = data.GetString("region");
                exsh.Cells[20, 33] = data.GetString("frp");
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

        private void but_all_mat_Click(object sender, EventArgs e)
        {
            generate_mol_report("ВСЕ МАТЕРИАЛЬНЫЕ ЗАПАСЫ");
        }

        private void but_rem_mat_Click(object sender, EventArgs e)
        {
            generate_mol_report("ОСТАТКИ МАТЕРИАЛЬНЫХ ЗАПАСОВ", true);
        }

        private void but_all_Click(object sender, EventArgs e)
        {
            generate_main_report("ВСЕ МАТЕРИАЛЬНЫЕ ЗАПАСЫ");
        }

        private void but_rem_Click(object sender, EventArgs e)
        {
            generate_main_report("ОСТАТКИ МАТЕРИАЛЬНЫХ ЗАПАСОВ", true);
        }

        private void but_frp_report_Click(object sender, EventArgs e)
        {
            report_frp frm = new report_frp(connect);
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
