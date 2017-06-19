namespace ARM_medacc
{
    partial class create_request
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
            this.gr_type_request = new System.Windows.Forms.GroupBox();
            this.rb_type_get = new System.Windows.Forms.RadioButton();
            this.rb_type_set = new System.Windows.Forms.RadioButton();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.col_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_type_request.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // gr_type_request
            // 
            this.gr_type_request.Controls.Add(this.rb_type_get);
            this.gr_type_request.Controls.Add(this.rb_type_set);
            this.gr_type_request.Location = new System.Drawing.Point(12, 12);
            this.gr_type_request.Name = "gr_type_request";
            this.gr_type_request.Size = new System.Drawing.Size(163, 78);
            this.gr_type_request.TabIndex = 0;
            this.gr_type_request.TabStop = false;
            this.gr_type_request.Text = "Тип заявки";
            // 
            // rb_type_get
            // 
            this.rb_type_get.AutoSize = true;
            this.rb_type_get.Location = new System.Drawing.Point(22, 44);
            this.rb_type_get.Name = "rb_type_get";
            this.rb_type_get.Size = new System.Drawing.Size(106, 17);
            this.rb_type_get.TabIndex = 1;
            this.rb_type_get.TabStop = true;
            this.rb_type_get.Text = "Списать с учета";
            this.rb_type_get.UseVisualStyleBackColor = true;
            // 
            // rb_type_set
            // 
            this.rb_type_set.AutoSize = true;
            this.rb_type_set.Location = new System.Drawing.Point(22, 20);
            this.rb_type_set.Name = "rb_type_set";
            this.rb_type_set.Size = new System.Drawing.Size(118, 17);
            this.rb_type_set.TabIndex = 0;
            this.rb_type_set.TabStop = true;
            this.rb_type_set.Text = "Поставить на учет";
            this.rb_type_set.UseVisualStyleBackColor = true;
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToOrderColumns = true;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_material,
            this.col_count,
            this.col_measure,
            this.col_region});
            this.dgv_table.Location = new System.Drawing.Point(12, 97);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.Size = new System.Drawing.Size(622, 283);
            this.dgv_table.TabIndex = 1;
            this.dgv_table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_CellEndEdit);
            this.dgv_table.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_CellValidated);
            this.dgv_table.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_table_EditingControlShowing);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 77);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // col_material
            // 
            this.col_material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_material.HeaderText = "Наименование";
            this.col_material.Name = "col_material";
            // 
            // col_count
            // 
            this.col_count.HeaderText = "Количество";
            this.col_count.Name = "col_count";
            // 
            // col_measure
            // 
            this.col_measure.HeaderText = "Ед. измерения";
            this.col_measure.Name = "col_measure";
            // 
            // col_region
            // 
            this.col_region.HeaderText = "Страна";
            this.col_region.Name = "col_region";
            // 
            // create_request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.gr_type_request);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "create_request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заявка";
            this.Load += new System.EventHandler(this.create_request_Load);
            this.gr_type_request.ResumeLayout(false);
            this.gr_type_request.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_type_request;
        private System.Windows.Forms.RadioButton rb_type_get;
        private System.Windows.Forms.RadioButton rb_type_set;
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_region;
    }
}