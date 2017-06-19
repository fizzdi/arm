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
    public partial class show_materials_mol : Form
    {
        MySqlConnection connect;
        public show_materials_mol(MySqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void show_materials_mol_Load(object sender, EventArgs e)
        {
            string commandtext = "select * from materials where frp = " + (Owner as main_form).user_id;
            connect.Open();
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
            connect.Close();
        }
    }
}
