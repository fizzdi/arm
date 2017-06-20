namespace ARM_medacc
{
    partial class reports
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
            this.but_all_mol = new System.Windows.Forms.Button();
            this.but_rem_mol = new System.Windows.Forms.Button();
            this.but_frp_report = new System.Windows.Forms.Button();
            this.but_all = new System.Windows.Forms.Button();
            this.but_rem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_all_mol
            // 
            this.but_all_mol.Location = new System.Drawing.Point(12, 12);
            this.but_all_mol.Name = "but_all_mol";
            this.but_all_mol.Size = new System.Drawing.Size(156, 42);
            this.but_all_mol.TabIndex = 1;
            this.but_all_mol.Text = "Все материальные запасы (с учетом МОЛ)";
            this.but_all_mol.UseVisualStyleBackColor = true;
            this.but_all_mol.Click += new System.EventHandler(this.but_all_mat_Click);
            // 
            // but_rem_mol
            // 
            this.but_rem_mol.Location = new System.Drawing.Point(174, 12);
            this.but_rem_mol.Name = "but_rem_mol";
            this.but_rem_mol.Size = new System.Drawing.Size(156, 42);
            this.but_rem_mol.TabIndex = 2;
            this.but_rem_mol.Text = "Остатки материальных запасов (с учетом МОЛ)";
            this.but_rem_mol.UseVisualStyleBackColor = true;
            this.but_rem_mol.Click += new System.EventHandler(this.but_rem_mat_Click);
            // 
            // but_frp_report
            // 
            this.but_frp_report.Location = new System.Drawing.Point(12, 108);
            this.but_frp_report.Name = "but_frp_report";
            this.but_frp_report.Size = new System.Drawing.Size(318, 42);
            this.but_frp_report.TabIndex = 3;
            this.but_frp_report.Text = "Материальные запасы МОЛ";
            this.but_frp_report.UseVisualStyleBackColor = true;
            // 
            // but_all
            // 
            this.but_all.Location = new System.Drawing.Point(12, 60);
            this.but_all.Name = "but_all";
            this.but_all.Size = new System.Drawing.Size(156, 42);
            this.but_all.TabIndex = 4;
            this.but_all.Text = "Все материальные запасы (без учета МОЛ)";
            this.but_all.UseVisualStyleBackColor = true;
            this.but_all.Click += new System.EventHandler(this.but_all_Click);
            // 
            // but_rem
            // 
            this.but_rem.Location = new System.Drawing.Point(174, 60);
            this.but_rem.Name = "but_rem";
            this.but_rem.Size = new System.Drawing.Size(156, 42);
            this.but_rem.TabIndex = 5;
            this.but_rem.Text = "Остатки материальных запасов (без учета МОЛ)";
            this.but_rem.UseVisualStyleBackColor = true;
            this.but_rem.Click += new System.EventHandler(this.but_rem_Click);
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 159);
            this.Controls.Add(this.but_rem);
            this.Controls.Add(this.but_all);
            this.Controls.Add(this.but_frp_report);
            this.Controls.Add(this.but_rem_mol);
            this.Controls.Add(this.but_all_mol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отчеты";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_all_mol;
        private System.Windows.Forms.Button but_rem_mol;
        private System.Windows.Forms.Button but_frp_report;
        private System.Windows.Forms.Button but_all;
        private System.Windows.Forms.Button but_rem;
    }
}