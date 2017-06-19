namespace ARM_medacc
{
    partial class assign_permissions
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
            this.cb_fio = new System.Windows.Forms.ComboBox();
            this.cb_grant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tabnum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_fio
            // 
            this.cb_fio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_fio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_fio.FormattingEnabled = true;
            this.cb_fio.Location = new System.Drawing.Point(132, 34);
            this.cb_fio.Name = "cb_fio";
            this.cb_fio.Size = new System.Drawing.Size(121, 21);
            this.cb_fio.TabIndex = 0;
            this.cb_fio.SelectedIndexChanged += new System.EventHandler(this.cb_fio_SelectedIndexChanged);
            // 
            // cb_grant
            // 
            this.cb_grant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_grant.FormattingEnabled = true;
            this.cb_grant.Items.AddRange(new object[] {
            "Администратор",
            "Материально ответственное лицо",
            "Бухгалтер"});
            this.cb_grant.Location = new System.Drawing.Point(132, 61);
            this.cb_grant.Name = "cb_grant";
            this.cb_grant.Size = new System.Drawing.Size(121, 21);
            this.cb_grant.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Права:";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(80, 93);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(114, 30);
            this.bt_save.TabIndex = 4;
            this.bt_save.Text = "Сохранить";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Табельный номер:";
            // 
            // cb_tabnum
            // 
            this.cb_tabnum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_tabnum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_tabnum.FormattingEnabled = true;
            this.cb_tabnum.Location = new System.Drawing.Point(132, 7);
            this.cb_tabnum.Name = "cb_tabnum";
            this.cb_tabnum.Size = new System.Drawing.Size(121, 21);
            this.cb_tabnum.TabIndex = 5;
            this.cb_tabnum.SelectedIndexChanged += new System.EventHandler(this.cb_tabnum_SelectedIndexChanged);
            // 
            // assign_permissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 134);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_tabnum);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_grant);
            this.Controls.Add(this.cb_fio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "assign_permissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Назначение прав доступа";
            this.Load += new System.EventHandler(this.assign_permissions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_fio;
        private System.Windows.Forms.ComboBox cb_grant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tabnum;
    }
}