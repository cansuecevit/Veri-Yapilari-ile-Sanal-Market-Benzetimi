namespace sanalmarket
{
    partial class MusteriGirisi
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
            this.btnListele = new System.Windows.Forms.Button();
            this.btnyorum = new System.Windows.Forms.Button();
            this.btnetiketArama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListele.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListele.Location = new System.Drawing.Point(32, 39);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(131, 58);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Ürünleri Ağaçtan Listeleme";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnyorum
            // 
            this.btnyorum.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnyorum.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyorum.Location = new System.Drawing.Point(217, 39);
            this.btnyorum.Name = "btnyorum";
            this.btnyorum.Size = new System.Drawing.Size(119, 58);
            this.btnyorum.TabIndex = 1;
            this.btnyorum.Text = "Yorum Yap";
            this.btnyorum.UseVisualStyleBackColor = false;
            this.btnyorum.Click += new System.EventHandler(this.btnyorum_Click);
            // 
            // btnetiketArama
            // 
            this.btnetiketArama.BackColor = System.Drawing.Color.LightCoral;
            this.btnetiketArama.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnetiketArama.Location = new System.Drawing.Point(400, 39);
            this.btnetiketArama.Name = "btnetiketArama";
            this.btnetiketArama.Size = new System.Drawing.Size(111, 58);
            this.btnetiketArama.TabIndex = 2;
            this.btnetiketArama.Text = "Etiket ile Arama Yap";
            this.btnetiketArama.UseVisualStyleBackColor = false;
            this.btnetiketArama.Click += new System.EventHandler(this.btnetiketArama_Click);
            // 
            // MusteriGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 150);
            this.Controls.Add(this.btnetiketArama);
            this.Controls.Add(this.btnyorum);
            this.Controls.Add(this.btnListele);
            this.Name = "MusteriGirisi";
            this.Text = "MusteriGirisi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnyorum;
        private System.Windows.Forms.Button btnetiketArama;
    }
}