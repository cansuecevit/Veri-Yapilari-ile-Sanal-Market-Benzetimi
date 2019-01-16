namespace sanalmarket
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMusteriGirisi = new System.Windows.Forms.Button();
            this.btnPersonelGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusteriGirisi
            // 
            this.btnMusteriGirisi.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGirisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMusteriGirisi.Location = new System.Drawing.Point(12, 86);
            this.btnMusteriGirisi.Name = "btnMusteriGirisi";
            this.btnMusteriGirisi.Size = new System.Drawing.Size(105, 74);
            this.btnMusteriGirisi.TabIndex = 0;
            this.btnMusteriGirisi.Text = "Müşteri Girişi";
            this.btnMusteriGirisi.UseVisualStyleBackColor = true;
            this.btnMusteriGirisi.Click += new System.EventHandler(this.btnMusteriGirisi_Click);
            // 
            // btnPersonelGirisi
            // 
            this.btnPersonelGirisi.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGirisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPersonelGirisi.Location = new System.Drawing.Point(157, 86);
            this.btnPersonelGirisi.Name = "btnPersonelGirisi";
            this.btnPersonelGirisi.Size = new System.Drawing.Size(101, 74);
            this.btnPersonelGirisi.TabIndex = 1;
            this.btnPersonelGirisi.Text = "Personel Girişi";
            this.btnPersonelGirisi.UseVisualStyleBackColor = true;
            this.btnPersonelGirisi.Click += new System.EventHandler(this.btnPersonelGirisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPersonelGirisi);
            this.Controls.Add(this.btnMusteriGirisi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriGirisi;
        private System.Windows.Forms.Button btnPersonelGirisi;
    }
}

