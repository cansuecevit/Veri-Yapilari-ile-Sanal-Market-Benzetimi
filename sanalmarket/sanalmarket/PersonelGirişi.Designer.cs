namespace sanalmarket
{
    partial class PersonelGirişi
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
            this.btnUrunArama = new System.Windows.Forms.Button();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.txtUrunEkle = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtUrunSil = new System.Windows.Forms.TextBox();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.cmbUrunAra = new System.Windows.Forms.ComboBox();
            this.cmbUrunEkle = new System.Windows.Forms.ComboBox();
            this.cmbUrunSil = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUrunArama
            // 
            this.btnUrunArama.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunArama.ForeColor = System.Drawing.Color.Crimson;
            this.btnUrunArama.Location = new System.Drawing.Point(12, 130);
            this.btnUrunArama.Name = "btnUrunArama";
            this.btnUrunArama.Size = new System.Drawing.Size(86, 32);
            this.btnUrunArama.TabIndex = 0;
            this.btnUrunArama.Text = "Ürün Ara";
            this.btnUrunArama.UseVisualStyleBackColor = true;
            this.btnUrunArama.Click += new System.EventHandler(this.btnUrunArama_Click);
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Location = new System.Drawing.Point(12, 30);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAra.TabIndex = 1;
            // 
            // txtUrunEkle
            // 
            this.txtUrunEkle.Location = new System.Drawing.Point(183, 30);
            this.txtUrunEkle.Name = "txtUrunEkle";
            this.txtUrunEkle.Size = new System.Drawing.Size(100, 20);
            this.txtUrunEkle.TabIndex = 3;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUrunEkle.Location = new System.Drawing.Point(183, 130);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(86, 32);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtUrunSil
            // 
            this.txtUrunSil.Location = new System.Drawing.Point(351, 30);
            this.txtUrunSil.Name = "txtUrunSil";
            this.txtUrunSil.Size = new System.Drawing.Size(100, 20);
            this.txtUrunSil.TabIndex = 5;
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.Location = new System.Drawing.Point(351, 130);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(90, 32);
            this.btnUrunSil.TabIndex = 4;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // cmbUrunAra
            // 
            this.cmbUrunAra.FormattingEnabled = true;
            this.cmbUrunAra.Items.AddRange(new object[] {
            "Bilgisayar",
            "Beyaz Eşya",
            "Kırtasiye"});
            this.cmbUrunAra.Location = new System.Drawing.Point(13, 72);
            this.cmbUrunAra.Name = "cmbUrunAra";
            this.cmbUrunAra.Size = new System.Drawing.Size(99, 21);
            this.cmbUrunAra.TabIndex = 6;
            // 
            // cmbUrunEkle
            // 
            this.cmbUrunEkle.FormattingEnabled = true;
            this.cmbUrunEkle.Items.AddRange(new object[] {
            "Bilgisayar",
            "Beyaz Eşya",
            "Kırtasiye"});
            this.cmbUrunEkle.Location = new System.Drawing.Point(183, 72);
            this.cmbUrunEkle.Name = "cmbUrunEkle";
            this.cmbUrunEkle.Size = new System.Drawing.Size(99, 21);
            this.cmbUrunEkle.TabIndex = 7;
            // 
            // cmbUrunSil
            // 
            this.cmbUrunSil.FormattingEnabled = true;
            this.cmbUrunSil.Items.AddRange(new object[] {
            "Bilgisayar",
            "Beyaz Eşya",
            "Kırtasiye"});
            this.cmbUrunSil.Location = new System.Drawing.Point(351, 72);
            this.cmbUrunSil.Name = "cmbUrunSil";
            this.cmbUrunSil.Size = new System.Drawing.Size(99, 21);
            this.cmbUrunSil.TabIndex = 8;
            // 
            // PersonelGirişi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 187);
            this.Controls.Add(this.cmbUrunSil);
            this.Controls.Add(this.cmbUrunEkle);
            this.Controls.Add(this.cmbUrunAra);
            this.Controls.Add(this.txtUrunSil);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.txtUrunEkle);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.txtUrunAra);
            this.Controls.Add(this.btnUrunArama);
            this.Name = "PersonelGirişi";
            this.Text = "PersonelGirişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrunArama;
        private System.Windows.Forms.TextBox txtUrunAra;
        private System.Windows.Forms.TextBox txtUrunEkle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtUrunSil;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.ComboBox cmbUrunAra;
        private System.Windows.Forms.ComboBox cmbUrunEkle;
        private System.Windows.Forms.ComboBox cmbUrunSil;
    }
}