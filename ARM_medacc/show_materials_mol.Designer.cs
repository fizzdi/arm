namespace ARM_medacc
{
    partial class show_materials_mol
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
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.col_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToAddRows = false;
            this.dgv_table.AllowUserToDeleteRows = false;
            this.dgv_table.AllowUserToOrderColumns = true;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_material,
            this.col_count,
            this.col_measure,
            this.col_region});
            this.dgv_table.Location = new System.Drawing.Point(12, 12);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.Size = new System.Drawing.Size(587, 368);
            this.dgv_table.TabIndex = 2;
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
            // 
            // col_measure
            // 
            this.col_measure.HeaderText = "Ед. измерения";
            this.col_measure.Name = "col_measure";
            this.col_measure.ReadOnly = true;
            // 
            // col_region
            // 
            this.col_region.HeaderText = "Страна";
            this.col_region.Name = "col_region";
            this.col_region.ReadOnly = true;
            // 
            // show_materials_mol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 392);
            this.Controls.Add(this.dgv_table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "show_materials_mol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Просмотр материалов МОЛ";
            this.Load += new System.EventHandler(this.show_materials_mol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_region;
    }
}