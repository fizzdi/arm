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
    public partial class appoint_frm : Form
    {
        MySqlConnection connect;
        public appoint_frm(MySqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void appoint_frm_Load(object sender, EventArgs e)
        {
            common.open_connect(connect);
            List<string> mols = new List<string>();
            MySqlCommand molcommand = new MySqlCommand("select id, concat(last_name, \" \", name, \" \", patronymic) as mol from users", connect);
            MySqlDataReader molread = molcommand.ExecuteReader();

            while (molread.Read())
                mols.Add(molread.GetString("mol"));

            molread.Close();

            string commandtext = "select * from materials t left join (select id, concat(last_name, \" \", name, \" \", patronymic) as mol from users) us on t.frp = us.id";
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
                dgv_table.Rows[i].Cells[col_mol.Index].Value = data.GetString("mol");
                var cb = (dgv_table.Rows[i].Cells[col_mol.Index] as DataGridViewComboBoxCell);
                cb.Items.AddRange(mols.ToArray());
                i++;
            }
            data.Close();
            common.close_connect(connect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            common.open_connect(connect);
            for (int i = 0; i < dgv_table.Rows.Count; ++i)
            {
                MySqlCommand molcommand = new MySqlCommand("select id, concat(last_name, \" \", name, \" \", patronymic) as mol from users", connect);
                MySqlDataReader molread = molcommand.ExecuteReader();
            }

            common.close_connect(connect);
        }
    }
}
