﻿namespace ARM_medacc
{
    partial class correct_request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(correct_request));
            this.lb_reqs = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_edit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_reqs
            // 
            this.lb_reqs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_reqs.FormattingEnabled = true;
            this.lb_reqs.ItemHeight = 21;
            this.lb_reqs.Location = new System.Drawing.Point(6, 19);
            this.lb_reqs.Name = "lb_reqs";
            this.lb_reqs.Size = new System.Drawing.Size(248, 214);
            this.lb_reqs.TabIndex = 0;
            this.lb_reqs.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lb_reqs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_reqs_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_reqs);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Номер заявки";
            // 
            // but_edit
            // 
            this.but_edit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_edit.Location = new System.Drawing.Point(18, 267);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(248, 53);
            this.but_edit.TabIndex = 2;
            this.but_edit.Text = "Изменить";
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // correct_request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 332);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "correct_request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Коррекция заявки";
            this.Load += new System.EventHandler(this.correct_request_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_reqs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_edit;
    }
}