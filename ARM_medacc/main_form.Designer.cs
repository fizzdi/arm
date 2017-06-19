namespace ARM_medacc
{
    partial class main_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_fio = new System.Windows.Forms.Label();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_create_user = new System.Windows.Forms.Button();
            this.bt_grant = new System.Windows.Forms.Button();
            this.bt_delete_user = new System.Windows.Forms.Button();
            this.but_confirm_request = new System.Windows.Forms.Button();
            this.bt_appoint = new System.Windows.Forms.Button();
            this.bt_report = new System.Windows.Forms.Button();
            this.bt_create_request = new System.Windows.Forms.Button();
            this.bt_edit_request = new System.Windows.Forms.Button();
            this.bt_show_materials = new System.Windows.Forms.Button();
            this.flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро пожаловать, ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_fio
            // 
            this.label_fio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_fio.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fio.Location = new System.Drawing.Point(16, 33);
            this.label_fio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_fio.Name = "label_fio";
            this.label_fio.Size = new System.Drawing.Size(353, 22);
            this.label_fio.TabIndex = 2;
            this.label_fio.Text = "label2";
            this.label_fio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flp
            // 
            this.flp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp.Controls.Add(this.bt_create_user);
            this.flp.Controls.Add(this.bt_grant);
            this.flp.Controls.Add(this.bt_delete_user);
            this.flp.Controls.Add(this.but_confirm_request);
            this.flp.Controls.Add(this.bt_appoint);
            this.flp.Controls.Add(this.bt_report);
            this.flp.Controls.Add(this.bt_create_request);
            this.flp.Controls.Add(this.bt_edit_request);
            this.flp.Controls.Add(this.bt_show_materials);
            this.flp.Location = new System.Drawing.Point(20, 75);
            this.flp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(349, 330);
            this.flp.TabIndex = 3;
            // 
            // bt_create_user
            // 
            this.bt_create_user.Location = new System.Drawing.Point(4, 4);
            this.bt_create_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_create_user.Name = "bt_create_user";
            this.bt_create_user.Size = new System.Drawing.Size(335, 28);
            this.bt_create_user.TabIndex = 0;
            this.bt_create_user.Text = "Создать пользователя";
            this.bt_create_user.UseVisualStyleBackColor = true;
            this.bt_create_user.Click += new System.EventHandler(this.bt_create_user_Click);
            // 
            // bt_grant
            // 
            this.bt_grant.Location = new System.Drawing.Point(4, 40);
            this.bt_grant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_grant.Name = "bt_grant";
            this.bt_grant.Size = new System.Drawing.Size(335, 28);
            this.bt_grant.TabIndex = 1;
            this.bt_grant.Text = "Назначить права доступа";
            this.bt_grant.UseVisualStyleBackColor = true;
            this.bt_grant.Click += new System.EventHandler(this.bt_grant_Click);
            // 
            // bt_delete_user
            // 
            this.bt_delete_user.Location = new System.Drawing.Point(4, 76);
            this.bt_delete_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_delete_user.Name = "bt_delete_user";
            this.bt_delete_user.Size = new System.Drawing.Size(335, 28);
            this.bt_delete_user.TabIndex = 2;
            this.bt_delete_user.Text = "Удалить пользователя";
            this.bt_delete_user.UseVisualStyleBackColor = true;
            this.bt_delete_user.Click += new System.EventHandler(this.bt_delete_user_Click);
            // 
            // but_confirm_request
            // 
            this.but_confirm_request.Location = new System.Drawing.Point(4, 112);
            this.but_confirm_request.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_confirm_request.Name = "but_confirm_request";
            this.but_confirm_request.Size = new System.Drawing.Size(335, 28);
            this.but_confirm_request.TabIndex = 10;
            this.but_confirm_request.Text = "Утверждение заявок";
            this.but_confirm_request.UseVisualStyleBackColor = true;
            this.but_confirm_request.Click += new System.EventHandler(this.but_confirm_request_Click);
            // 
            // bt_appoint
            // 
            this.bt_appoint.Location = new System.Drawing.Point(4, 148);
            this.bt_appoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_appoint.Name = "bt_appoint";
            this.bt_appoint.Size = new System.Drawing.Size(335, 28);
            this.bt_appoint.TabIndex = 5;
            this.bt_appoint.Text = "Назначить МОЛ";
            this.bt_appoint.UseVisualStyleBackColor = true;
            this.bt_appoint.Click += new System.EventHandler(this.bt_appoint_Click);
            // 
            // bt_report
            // 
            this.bt_report.Location = new System.Drawing.Point(4, 184);
            this.bt_report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_report.Name = "bt_report";
            this.bt_report.Size = new System.Drawing.Size(335, 28);
            this.bt_report.TabIndex = 6;
            this.bt_report.Text = "Составить отчёт";
            this.bt_report.UseVisualStyleBackColor = true;
            this.bt_report.Click += new System.EventHandler(this.bt_report_Click);
            // 
            // bt_create_request
            // 
            this.bt_create_request.Location = new System.Drawing.Point(4, 220);
            this.bt_create_request.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_create_request.Name = "bt_create_request";
            this.bt_create_request.Size = new System.Drawing.Size(335, 28);
            this.bt_create_request.TabIndex = 7;
            this.bt_create_request.Text = "Составить заявку";
            this.bt_create_request.UseVisualStyleBackColor = true;
            this.bt_create_request.Click += new System.EventHandler(this.bt_create_request_Click);
            // 
            // bt_edit_request
            // 
            this.bt_edit_request.Location = new System.Drawing.Point(4, 256);
            this.bt_edit_request.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_edit_request.Name = "bt_edit_request";
            this.bt_edit_request.Size = new System.Drawing.Size(335, 28);
            this.bt_edit_request.TabIndex = 8;
            this.bt_edit_request.Text = "Корректировать заявку";
            this.bt_edit_request.UseVisualStyleBackColor = true;
            this.bt_edit_request.Click += new System.EventHandler(this.bt_edit_request_Click);
            // 
            // bt_show_materials
            // 
            this.bt_show_materials.Location = new System.Drawing.Point(4, 292);
            this.bt_show_materials.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_show_materials.Name = "bt_show_materials";
            this.bt_show_materials.Size = new System.Drawing.Size(335, 28);
            this.bt_show_materials.TabIndex = 9;
            this.bt_show_materials.Text = "Посмотреть материальные запасы";
            this.bt_show_materials.UseVisualStyleBackColor = true;
            this.bt_show_materials.Click += new System.EventHandler(this.bt_show_materials_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 420);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.label_fio);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 272);
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС УМ ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_fio;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Button bt_create_user;
        private System.Windows.Forms.Button bt_grant;
        private System.Windows.Forms.Button bt_delete_user;
        private System.Windows.Forms.Button bt_appoint;
        private System.Windows.Forms.Button bt_report;
        private System.Windows.Forms.Button bt_create_request;
        private System.Windows.Forms.Button bt_edit_request;
        private System.Windows.Forms.Button bt_show_materials;
        private System.Windows.Forms.Button but_confirm_request;
    }
}

