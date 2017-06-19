namespace ARM_medacc
{
    partial class delete_user
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
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tabnum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_fio = new System.Windows.Forms.ComboBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Табельный номер:";
            // 
            // cb_tabnum
            // 
            this.cb_tabnum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_tabnum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_tabnum.FormattingEnabled = true;
            this.cb_tabnum.Location = new System.Drawing.Point(132, 12);
            this.cb_tabnum.Name = "cb_tabnum";
            this.cb_tabnum.Size = new System.Drawing.Size(121, 21);
            this.cb_tabnum.TabIndex = 9;
            this.cb_tabnum.SelectedIndexChanged += new System.EventHandler(this.cb_tabnum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО пользователя:";
            // 
            // cb_fio
            // 
            this.cb_fio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_fio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_fio.FormattingEnabled = true;
            this.cb_fio.Location = new System.Drawing.Point(132, 39);
            this.cb_fio.Name = "cb_fio";
            this.cb_fio.Size = new System.Drawing.Size(121, 21);
            this.cb_fio.TabIndex = 7;
            this.cb_fio.SelectedIndexChanged += new System.EventHandler(this.cb_fio_SelectedIndexChanged);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(78, 66);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(110, 48);
            this.bt_delete.TabIndex = 11;
            this.bt_delete.Text = "Удалить";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // delete_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 122);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_tabnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_fio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "delete_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удалить пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tabnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_fio;
        private System.Windows.Forms.Button bt_delete;
    }
}