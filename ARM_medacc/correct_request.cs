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
    public partial class correct_request : Form
    {
        MySqlConnection connect;
        public correct_request(MySqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            but_edit.Enabled = true;
        }

        private void correct_request_Load(object sender, EventArgs e)
        {
            lb_reqs.Items.Clear();
            string commandtext = string.Format("select * from requests where frp = {0} and status = 2", (Owner as main_form).user_id);
                        common.open_connect(connect);
            MySqlCommand command = new MySqlCommand(commandtext, connect);
            MySqlDataReader data = command.ExecuteReader();
            while (data.Read())
                lb_reqs.Items.Add(data.GetString("code"));
                        common.close_connect(connect);
            data.Close();
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            create_request frm = new create_request(connect, int.Parse((string)lb_reqs.SelectedItem));
            frm.Owner = Owner;
            frm.ShowDialog();
            correct_request_Load(sender, e);
        }

        private void lb_reqs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lb_reqs.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                lb_reqs.SelectedIndex = index;
                but_edit_Click(sender, e);
            }
        }
    }
}
