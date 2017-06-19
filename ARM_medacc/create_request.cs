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
        public create_request(MySqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void dgv_table_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == col_count.Index)
            {

            }
        }

        private void create_request_Load(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            tb_date.Text = string.Format("{0}-{1}-{2}", (date.Day < 10 ? "0" : "") + date.Day, (date.Month < 10 ? "0" : "") + date.Month, date.Year);
        }

        private void dgv_table_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv_table.CurrentCell.ColumnIndex == col_code.Index)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    string commandtext = "select distinct code from materials";
                    connect.Open();
                    MySqlCommand command = new MySqlCommand(commandtext, connect);
                    MySqlDataReader data = command.ExecuteReader();
                    var source = new AutoCompleteStringCollection();
                    while (data.Read())
                        source.Add(data.GetString("code"));
                    connect.Close();
                    data.Close();

                    txt.AutoCompleteMode = AutoCompleteMode.Append;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource = source;
                }
            }

            if (dgv_table.CurrentCell.ColumnIndex == col_material.Index)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    string commandtext = "select distinct description from materials";
                    connect.Open();
                    MySqlCommand command = new MySqlCommand(commandtext, connect);
                    MySqlDataReader data = command.ExecuteReader();
                    var source = new AutoCompleteStringCollection();
                    while (data.Read())
                        source.Add(data.GetString("description"));
                    connect.Close();
                    data.Close();

                    txt.AutoCompleteMode = AutoCompleteMode.Append;
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
                    connect.Open();
                    MySqlCommand command = new MySqlCommand(commandtext, connect);
                    MySqlDataReader data = command.ExecuteReader();
                    var source = new AutoCompleteStringCollection();
                    while (data.Read())
                        source.Add(data.GetString("region"));
                    connect.Close();
                    data.Close();

                    txt.AutoCompleteMode = AutoCompleteMode.Append;
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
                    connect.Open();
                    MySqlCommand command = new MySqlCommand(commandtext, connect);
                    MySqlDataReader data = command.ExecuteReader();
                    var source = new AutoCompleteStringCollection();
                    while (data.Read())
                        source.Add(data.GetString("measure"));
                    connect.Close();
                    data.Close();

                    txt.AutoCompleteMode = AutoCompleteMode.Append;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource = source;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            connect.Open();
            MySqlCommand command = new MySqlCommand("select code from requests order by id desc limit 1", connect);
            MySqlDataReader data = command.ExecuteReader();
            if (data.Read())
                num = data.GetInt32("code");
            data.Close();
            num++;
            for (int i = 0; i < dgv_table.RowCount - 1; ++i)
            {
                command.CommandText = string.Format("INSERT INTO `materials` (`id`, `code`, `description`, `measure`, `amount`, `region`, `frp`, `status`, `request`) VALUES (NULL, {0}, '{1}', '{2}', {3}, '{4}', {5}, {6}, {7});",
                    dgv_table.Rows[i].Cells[col_code.Index].Value, dgv_table.Rows[i].Cells[col_material.Index].Value,
                    dgv_table.Rows[i].Cells[col_measure.Index].Value, dgv_table.Rows[i].Cells[col_count.Index].Value, dgv_table.Rows[i].Cells[col_region.Index].Value, (Owner as main_form).user_id, 0, num);
                command.ExecuteNonQuery();
            }
            command.CommandText = string.Format("INSERT INTO `requests` (`code`, `status`, `frp`, `type`) VALUES('{0}', 0, {1}, {2});", num, (Owner as main_form).user_id, (rb_type_get.Checked ? 1: 0));
            command.ExecuteNonQuery();

            connect.Close();
            dgv_table.Rows.Clear();

            MessageBox.Show("Заявка #" + num + " успешно добавлена!");
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

            if (e.ColumnIndex == col_code.Index)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand(string.Format("select * from materials where code = '{0}'", dgv_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value), connect);
                MySqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                    dgv_table.Rows[e.RowIndex].Cells[col_material.Index].Value = data.GetString("description");
                    dgv_table.Rows[e.RowIndex].Cells[col_region.Index].Value = data.GetString("region");
                    dgv_table.Rows[e.RowIndex].Cells[col_measure.Index].Value = data.GetString("measure");
                }
                data.Close();
                connect.Close();
            }

            if (e.ColumnIndex == col_material.Index)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand(string.Format("select * from materials where description = '{0}'", dgv_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value), connect);
                MySqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                    dgv_table.Rows[e.RowIndex].Cells[col_code.Index].Value = data.GetString("code");
                    dgv_table.Rows[e.RowIndex].Cells[col_region.Index].Value = data.GetString("region");
                    dgv_table.Rows[e.RowIndex].Cells[col_measure.Index].Value = data.GetString("measure");
                }
                data.Close();
                connect.Close();
            }
        }
    }
}
