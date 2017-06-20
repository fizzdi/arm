namespace ARM_medacc
{
    partial class confirm_request
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirm_request));
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.col_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.rb_type_set = new System.Windows.Forms.RadioButton();
            this.rb_type_get = new System.Windows.Forms.RadioButton();
            this.gr_type_request = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_mol = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.gr_type_request.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToAddRows = false;
            this.dgv_table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_material,
            this.col_count,
            this.col_measure,
            this.col_region});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_table.Location = new System.Drawing.Point(12, 97);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.Size = new System.Drawing.Size(714, 283);
            this.dgv_table.TabIndex = 1;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "Утвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_type_set
            // 
            this.rb_type_set.AutoSize = true;
            this.rb_type_set.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_type_set.Location = new System.Drawing.Point(22, 20);
            this.rb_type_set.Name = "rb_type_set";
            this.rb_type_set.Size = new System.Drawing.Size(175, 25);
            this.rb_type_set.TabIndex = 0;
            this.rb_type_set.TabStop = true;
            this.rb_type_set.Text = "Поставить на учет";
            this.rb_type_set.UseVisualStyleBackColor = true;
            // 
            // rb_type_get
            // 
            this.rb_type_get.AutoSize = true;
            this.rb_type_get.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_type_get.Location = new System.Drawing.Point(22, 44);
            this.rb_type_get.Name = "rb_type_get";
            this.rb_type_get.Size = new System.Drawing.Size(157, 25);
            this.rb_type_get.TabIndex = 1;
            this.rb_type_get.TabStop = true;
            this.rb_type_get.Text = "Списать с учета";
            this.rb_type_get.UseVisualStyleBackColor = true;
            // 
            // gr_type_request
            // 
            this.gr_type_request.Controls.Add(this.rb_type_get);
            this.gr_type_request.Controls.Add(this.rb_type_set);
            this.gr_type_request.Enabled = false;
            this.gr_type_request.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gr_type_request.Location = new System.Drawing.Point(12, 12);
            this.gr_type_request.Name = "gr_type_request";
            this.gr_type_request.Size = new System.Drawing.Size(221, 78);
            this.gr_type_request.TabIndex = 0;
            this.gr_type_request.TabStop = false;
            this.gr_type_request.Text = "Тип заявки";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_mol);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(239, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "МОЛ";
            // 
            // tb_mol
            // 
            this.tb_mol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_mol.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_mol.Location = new System.Drawing.Point(7, 19);
            this.tb_mol.Name = "tb_mol";
            this.tb_mol.ReadOnly = true;
            this.tb_mol.Size = new System.Drawing.Size(473, 29);
            this.tb_mol.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Image = global::ARM_medacc.Properties.Resources.cancel;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(389, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(337, 65);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отклонить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // confirm_request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 460);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.gr_type_request);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "confirm_request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заявка";
            this.Load += new System.EventHandler(this.confirm_request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.gr_type_request.ResumeLayout(false);
            this.gr_type_request.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_type_set;
        private System.Windows.Forms.RadioButton rb_type_get;
        private System.Windows.Forms.GroupBox gr_type_request;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_mol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_region;
    }
}