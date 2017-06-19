using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_medacc
{
    static class common
    {
        static public bool check_textbox(TextBox tb, string Message, string Caption)
        {
            if (tb.Text == "")
            {
                MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return true;
            }
            return false;
        }
    }
}
