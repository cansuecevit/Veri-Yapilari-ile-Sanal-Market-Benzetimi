﻿namespace sanalmarket
{
    partial class Yorum_Yap
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
            this.rtbYorum = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnyorumugonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbYorum
            // 
            this.rtbYorum.Location = new System.Drawing.Point(12, 52);
            this.rtbYorum.Name = "rtbYorum";
            this.rtbYorum.Size = new System.Drawing.Size(148, 133);
            this.rtbYorum.TabIndex = 0;
            this.rtbYorum.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yorumu Yazınız";
            // 
            // btnyorumugonder
            // 
            this.btnyorumugonder.Location = new System.Drawing.Point(142, 203);
            this.btnyorumugonder.Name = "btnyorumugonder";
            this.btnyorumugonder.Size = new System.Drawing.Size(101, 32);
            this.btnyorumugonder.TabIndex = 2;
            this.btnyorumugonder.Text = "Yorumu Gönder";
            this.btnyorumugonder.UseVisualStyleBackColor = true;
            this.btnyorumugonder.Click += new System.EventHandler(this.btnyorumugonder_Click);
            // 
            // Yorum_Yap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnyorumugonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbYorum);
            this.Name = "Yorum_Yap";
            this.Text = "Yorum_Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbYorum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnyorumugonder;
    }
}