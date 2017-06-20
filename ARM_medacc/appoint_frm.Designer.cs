namespace ARM_medacc
{
    partial class appoint_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appoint_frm));
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.col_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToAddRows = false;
            this.dgv_table.AllowUserToDeleteRows = false;
            this.dgv_table.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_material,
            this.col_count,
            this.col_measure,
            this.col_region,
            this.col_mol});
            this.dgv_table.Location = new System.Drawing.Point(12, 12);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.Size = new System.Drawing.Size(883, 338);
            this.dgv_table.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(882, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // col_material
            // 
            this.col_material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_material.HeaderText = "Наименование";
            this.col_material.Name = "col_material";
            this.col_material.ReadOnly = true;
            // 
            // col_count
            // 
            this.col_count.HeaderText = "Количество";
            this.col_count.Name = "col_count";
            this.col_count.ReadOnly = true;
            this.col_count.Width = 120;
            // 
            // col_measure
            // 
            this.col_measure.HeaderText = "Ед. измерения";
            this.col_measure.Name = "col_measure";
            this.col_measure.ReadOnly = true;
            // 
            // col_region
            // 
            this.col_region.HeaderText = "Страна происхождения";
            this.col_region.Name = "col_region";
            this.col_region.ReadOnly = true;
            this.col_region.Width = 150;
            // 
            // col_mol
            // 
            this.col_mol.HeaderText = "МОЛ";
            this.col_mol.Name = "col_mol";
            this.col_mol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_mol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_mol.Width = 200;
            // 
            // appoint_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "appoint_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Назначение МОЛ";
            this.Load += new System.EventHandler(this.appoint_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_region;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_mol;
    }
}