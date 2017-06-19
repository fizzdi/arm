namespace ARM_medacc
{
    partial class create_user
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
            this.tb_tablnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_patronymic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_grant = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_tablnum
            // 
            this.tb_tablnum.Location = new System.Drawing.Point(121, 10);
            this.tb_tablnum.Name = "tb_tablnum";
            this.tb_tablnum.Size = new System.Drawing.Size(151, 20);
            this.tb_tablnum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Табельный номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия:";
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(121, 62);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(151, 20);
            this.tb_lastname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(121, 88);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(151, 20);
            this.tb_name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отчество:";
            // 
            // tb_patronymic
            // 
            this.tb_patronymic.Location = new System.Drawing.Point(121, 114);
            this.tb_patronymic.Name = "tb_patronymic";
            this.tb_patronymic.Size = new System.Drawing.Size(151, 20);
            this.tb_patronymic.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пароль:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(121, 36);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(151, 20);
            this.tb_password.TabIndex = 1;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(88, 170);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(116, 46);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Сохранить";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Права:";
            // 
            // cb_grant
            // 
            this.cb_grant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_grant.FormattingEnabled = true;
            this.cb_grant.Items.AddRange(new object[] {
            "Администратор",
            "Бухгалтер",
            "Материально ответственное лицо"});
            this.cb_grant.Location = new System.Drawing.Point(121, 143);
            this.cb_grant.Name = "cb_grant";
            this.cb_grant.Size = new System.Drawing.Size(151, 21);
            this.cb_grant.TabIndex = 5;
            // 
            // create_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.cb_grant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_patronymic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tablnum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "create_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создать пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_tablnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_patronymic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_grant;
    }
}