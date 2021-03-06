﻿using MySql.Data.MySqlClient;
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
    public partial class create_request : Form
    {
        MySqlConnection connect;
        int req = 0;
        public create_request(MySqlConnection connect, int req = 0, bool buh = false)
        {
            InitializeComponent();
            this.connect = connect;
            this.req = req;
        }

        private void create_request_Load(object sender, EventArgs e)
        {
            if (req == 0) return;

            button2.Visible = true;
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
                if (data.GetInt32("type") == 0)
                    rb_type_set.Checked = true;
                else rb_type_get.Checked = true;
            }
            data.Close();
            common.close_connect(connect);
        }

        private void dgv_table_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv_table.CurrentCell.ColumnIndex == col_material.Index)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    string commandtext = "select distinct description from materials";
                    common.open_connect(connect);
                    MySqlCommand command = new MySqlCommand(commandtext, connect);
                    MySqlDataReader data = command.ExecuteReader();
                    var source = new AutoCompleteStringCollection();
                    while (data.Read())
                        source.Add(data.GetString("description"));
                    common.close_connect(connect);
                    data.Close();

                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource = source;
                }
            }

            if (dgv_table.CurrentCell.ColumnIndex == col_region.Index)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    string commandtext = "select distinct region from materials";
                    common.open_connect(connect);
                    MySqlCommand command = new MySqlCommand(commandtext, connect);
                    MySqlDataReader data = command.ExecuteReader();
                    var source = new AutoCompleteStringCollection();
                    while (data.Read())
                        source.Add(data.GetString("region"));
                    common.close_connect(connect);
                    data.Close();

                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource = source;
                }
            }

            if (dgv_table.CurrentCell.ColumnIndex == col_measure.Index)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    string commandtext = "select distinct measure from materials";
                    common.open_connect(connect);
                    MySqlCommand command = new MySqlCommand(commandtext, connect);
                    MySqlDataReader data = command.ExecuteReader();
                    var source = new AutoCompleteStringCollection();
                    while (data.Read())
                        source.Add(data.GetString("measure"));
                    common.close_connect(connect);
                    data.Close();

                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource = source;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            common.open_connect(connect);
            MySqlCommand command = new MySqlCommand("select * from materials where frp = " + (Owner as main_form).user_id, connect);
            dgv_table.EndEdit();
            MySqlDataReader data = command.ExecuteReader();
            List<List<object>> list_base = new List<List<object>>();
            while (data.Read())
            {
                List<object> cur_mat = new List<object>();
                cur_mat.Add(data.GetString("description"));
                cur_mat.Add(data.GetString("amount"));
                cur_mat.Add(data.GetString("region"));
                cur_mat.Add(data.GetString("measure"));
                list_base.Add(cur_mat);
            }
            data.Close();

            for (int i = 0; i < dgv_table.Rows.Count - 1; ++i)
            {
                if (dgv_table.Rows[i].Cells[col_material.Index].Value.ToString() == "")
                {
                    MessageBox.Show("Отсутствует название материала в строке" + i + 1);
                    dgv_table.Rows[i].Cells[col_material.Index].Selected = true;
                    return;
                }

                if (dgv_table.Rows[i].Cells[col_region.Index].Value.ToString() == "")
                {
                    MessageBox.Show("Отсутствует регион производства материала в строке" + i + 1);
                    dgv_table.Rows[i].Cells[col_region.Index].Selected = true;
                    return;
                }

                if (dgv_table.Rows[i].Cells[col_measure.Index].Value.ToString() == "")
                {
                    MessageBox.Show("Отсутствует единица измерения материала в строке" + i + 1);
                    dgv_table.Rows[i].Cells[col_measure.Index].Selected = true;
                    return;
                }

                if (dgv_table.Rows[i].Cells[col_count.Index].Value.ToString() == "")
                {
                    MessageBox.Show("Отсутствует количество материала в строке" + i + 1);
                    dgv_table.Rows[i].Cells[col_count.Index].Selected = true;
                    return;
                }
                if (rb_type_set.Checked) continue;

                command.CommandText = string.Format("select amount from materials where description = '{0}' and region = '{1}' and measure = '{2}' and frp = {3}",
                    dgv_table.Rows[i].Cells[col_material.Index].Value, dgv_table.Rows[i].Cells[col_region.Index].Value,
                    dgv_table.Rows[i].Cells[col_measure.Index].Value, (Owner as main_form).user_id);
                using (MySqlDataReader data2 = command.ExecuteReader())
                {
                    if (data2.Read())
                    {
                        int count = data2.GetInt32("amount");

                        if (count < int.Parse(dgv_table.Rows[i].Cells[col_count.Index].Value.ToString()))
                        {
                            MessageBox.Show(string.Format("Не хватает материала зарегистрированного на вас! ({0}, {1}, {2})",
                                dgv_table.Rows[i].Cells[col_material.Index].Value, dgv_table.Rows[i].Cells[col_region.Index].Value,
                                dgv_table.Rows[i].Cells[col_measure.Index].Value));
                            dgv_table.Rows[i].Cells[col_count.Index].Selected = true;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(string.Format("На вас не зарегистрирован такой материал! ({0}, {1}, {2})", dgv_table.Rows[i].Cells[col_material.Index].Value, dgv_table.Rows[i].Cells[col_region.Index].Value,
                        dgv_table.Rows[i].Cells[col_measure.Index].Value));
                        return;
                    }
                }
            }


            MySqlCommand command2 = new MySqlCommand("select code from requests order by id desc limit 1", connect);
            int num = 0;
            if (req == 0)
            {
                MySqlDataReader code_reader = command2.ExecuteReader();
                if (code_reader.Read())
                    num = code_reader.GetInt32("code");
                code_reader.Close();
                num++;
            }
            else
            {
                num = req;
                command.CommandText = string.Format("DELETE FROM `temp_materials` WHERE `request` = {0}", num);
                command.ExecuteNonQuery();
                command.CommandText = string.Format("DELETE FROM `requests` WHERE `code` = {0}", num);
                command.ExecuteNonQuery();
            }
            for (int i = 0; i < dgv_table.RowCount - 1; ++i)
            {
                command.CommandText = string.Format("INSERT INTO `temp_materials` (`description`, `measure`, `amount`, `region`, `frp`, `request`) VALUES ('{0}', '{1}', {2:0.00}, '{3}', '{4}', {5});",
                    dgv_table.Rows[i].Cells[col_material.Index].Value, dgv_table.Rows[i].Cells[col_measure.Index].Value, dgv_table.Rows[i].Cells[col_count.Index].Value,
                    dgv_table.Rows[i].Cells[col_region.Index].Value, (Owner as main_form).user_id, num);
                command.ExecuteNonQuery();
            }
            command.CommandText = string.Format("INSERT INTO `requests` (`code`, `status`, `frp`, `type`) VALUES('{0}', 0, {1}, {2});", num, (Owner as main_form).user_id, (rb_type_get.Checked ? 1 : 0));
            command.ExecuteNonQuery();

            common.close_connect(connect);
            dgv_table.Rows.Clear();

            if (req == 0)
                MessageBox.Show("Заявка #" + num + " успешно добавлена!");
            else MessageBox.Show("Заявка #" + num + " успешно изменена!");
            Close();
        }

        private void dgv_table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == col_count.Index)
            {
                int a;
                foreach (char c in (string)dgv_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("Количество должно быть целым числом!");
                        dgv_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                        break;
                    }
                }
            }

            if (e.ColumnIndex == col_material.Index)
            {
                common.open_connect(connect);
                MySqlCommand command = new MySqlCommand(string.Format("select * from materials where description = '{0}'", dgv_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value), connect);
                MySqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                    dgv_table.Rows[e.RowIndex].Cells[col_region.Index].Value = data.GetString("region");
                    dgv_table.Rows[e.RowIndex].Cells[col_measure.Index].Value = data.GetString("measure");
                }
                data.Close();
                common.close_connect(connect);
            }
        }

        private void rb_type_get_CheckedChanged(object sender, EventArgs e)
        {
            dgv_table.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            common.open_connect(connect);
            MySqlCommand command = new MySqlCommand("update requests set status = 3 where code = " + req, connect);
            command.ExecuteNonQuery();
            common.close_connect(connect);
            MessageBox.Show("Заявка #" + req + " удалена!");
            Close();
        }
    }
}
