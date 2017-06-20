using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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

        static public void open_connect(MySql.Data.MySqlClient.MySqlConnection con)
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
        }

        static public void close_connect(MySql.Data.MySqlClient.MySqlConnection con)
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        static public void dublicate_row(int rowIndex, Excel.Worksheet exsh)
        {
            Excel.Range rng = exsh.Cells[rowIndex, 1];
            rng = rng.EntireRow;
            rng.Insert(Excel.XlInsertShiftDirection.xlShiftDown, true);
            rng = exsh.Range[exsh.Cells[rowIndex, 1], exsh.Cells[rowIndex, 26]];
            exsh.Rows[rowIndex+1].Copy();
            rng.PasteSpecial();
            exsh.Application.CutCopyMode = Excel.XlCutCopyMode.xlCopy;
        }
    }
}
