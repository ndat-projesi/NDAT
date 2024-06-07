namespace NDAT
{
    partial class Rezervasyon_Kutusu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FiyatVeriLabel = new System.Windows.Forms.Label();
            this.FiyatLabel = new System.Windows.Forms.Label();
            this.ÖdemeButonu = new System.Windows.Forms.Button();
            this.SaatVeriLabel = new System.Windows.Forms.Label();
            this.TarihVeriLabel = new System.Windows.Forms.Label();
            this.RotaVeriLabel = new System.Windows.Forms.Label();
            this.SaatLabel = new System.Windows.Forms.Label();
            this.TarihLabel = new System.Windows.Forms.Label();
            this.RotaLabel = new System.Windows.Forms.Label();
            this.IptalButonu = new System.Windows.Forms.Button();
            this.DurumLabel = new System.Windows.Forms.Label();
            this.KoltukLabel = new System.Windows.Forms.Label();
            this.KoltukVeriLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FiyatVeriLabel
            // 
            this.FiyatVeriLabel.AutoSize = true;
            this.FiyatVeriLabel.Location = new System.Drawing.Point(42, 39);
            this.FiyatVeriLabel.Name = "FiyatVeriLabel";
            this.FiyatVeriLabel.Size = new System.Drawing.Size(67, 13);
            this.FiyatVeriLabel.TabIndex = 17;
            this.FiyatVeriLabel.Text = "Fiyat not set.";
            // 
            // FiyatLabel
            // 
            this.FiyatLabel.AutoSize = true;
            this.FiyatLabel.Location = new System.Drawing.Point(3, 39);
            this.FiyatLabel.Name = "FiyatLabel";
            this.FiyatLabel.Size = new System.Drawing.Size(32, 13);
            this.FiyatLabel.TabIndex = 16;
            this.FiyatLabel.Text = "Fiyat:";
            // 
            // ÖdemeButonu
            // 
            this.ÖdemeButonu.Location = new System.Drawing.Point(163, 83);
            this.ÖdemeButonu.Name = "ÖdemeButonu";
            this.ÖdemeButonu.Size = new System.Drawing.Size(75, 23);
            this.ÖdemeButonu.TabIndex = 15;
            this.ÖdemeButonu.Text = "Ödeme Yap";
            this.ÖdemeButonu.UseVisualStyleBackColor = true;
            this.ÖdemeButonu.Click += new System.EventHandler(this.ÖdemeButonu_Click);
            // 
            // SaatVeriLabel
            // 
            this.SaatVeriLabel.AutoSize = true;
            this.SaatVeriLabel.Location = new System.Drawing.Point(42, 26);
            this.SaatVeriLabel.Name = "SaatVeriLabel";
            this.SaatVeriLabel.Size = new System.Drawing.Size(68, 13);
            this.SaatVeriLabel.TabIndex = 14;
            this.SaatVeriLabel.Text = "Time not set.";
            // 
            // TarihVeriLabel
            // 
            this.TarihVeriLabel.AutoSize = true;
            this.TarihVeriLabel.Location = new System.Drawing.Point(42, 13);
            this.TarihVeriLabel.Name = "TarihVeriLabel";
            this.TarihVeriLabel.Size = new System.Drawing.Size(68, 13);
            this.TarihVeriLabel.TabIndex = 13;
            this.TarihVeriLabel.Text = "Date not set.";
            // 
            // RotaVeriLabel
            // 
            this.RotaVeriLabel.AutoSize = true;
            this.RotaVeriLabel.Location = new System.Drawing.Point(42, 0);
            this.RotaVeriLabel.Name = "RotaVeriLabel";
            this.RotaVeriLabel.Size = new System.Drawing.Size(72, 13);
            this.RotaVeriLabel.TabIndex = 12;
            this.RotaVeriLabel.Text = "Value not set.";
            // 
            // SaatLabel
            // 
            this.SaatLabel.AutoSize = true;
            this.SaatLabel.Location = new System.Drawing.Point(3, 26);
            this.SaatLabel.Name = "SaatLabel";
            this.SaatLabel.Size = new System.Drawing.Size(32, 13);
            this.SaatLabel.TabIndex = 11;
            this.SaatLabel.Text = "Saat:";
            // 
            // TarihLabel
            // 
            this.TarihLabel.AutoSize = true;
            this.TarihLabel.Location = new System.Drawing.Point(3, 13);
            this.TarihLabel.Name = "TarihLabel";
            this.TarihLabel.Size = new System.Drawing.Size(34, 13);
            this.TarihLabel.TabIndex = 10;
            this.TarihLabel.Text = "Tarih:";
            // 
            // RotaLabel
            // 
            this.RotaLabel.AutoSize = true;
            this.RotaLabel.Location = new System.Drawing.Point(3, 0);
            this.RotaLabel.Name = "RotaLabel";
            this.RotaLabel.Size = new System.Drawing.Size(33, 13);
            this.RotaLabel.TabIndex = 9;
            this.RotaLabel.Text = "Rota:";
            // 
            // IptalButonu
            // 
            this.IptalButonu.Location = new System.Drawing.Point(3, 83);
            this.IptalButonu.Name = "IptalButonu";
            this.IptalButonu.Size = new System.Drawing.Size(75, 23);
            this.IptalButonu.TabIndex = 18;
            this.IptalButonu.Text = "İptal Et";
            this.IptalButonu.UseVisualStyleBackColor = true;
            this.IptalButonu.Click += new System.EventHandler(this.IptalButonu_Click);
            // 
            // DurumLabel
            // 
            this.DurumLabel.AutoSize = true;
            this.DurumLabel.Location = new System.Drawing.Point(178, 0);
            this.DurumLabel.MinimumSize = new System.Drawing.Size(60, 17);
            this.DurumLabel.Name = "DurumLabel";
            this.DurumLabel.Size = new System.Drawing.Size(60, 17);
            this.DurumLabel.TabIndex = 19;
            this.DurumLabel.Text = "Bekleyen";
            this.DurumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // KoltukLabel
            // 
            this.KoltukLabel.AutoSize = true;
            this.KoltukLabel.Location = new System.Drawing.Point(3, 52);
            this.KoltukLabel.Name = "KoltukLabel";
            this.KoltukLabel.Size = new System.Drawing.Size(40, 13);
            this.KoltukLabel.TabIndex = 20;
            this.KoltukLabel.Text = "Koltuk:";
            // 
            // KoltukVeriLabel
            // 
            this.KoltukVeriLabel.AutoSize = true;
            this.KoltukVeriLabel.Location = new System.Drawing.Point(42, 52);
            this.KoltukVeriLabel.Name = "KoltukVeriLabel";
            this.KoltukVeriLabel.Size = new System.Drawing.Size(75, 13);
            this.KoltukVeriLabel.TabIndex = 21;
            this.KoltukVeriLabel.Text = "Koltuk not set.";
            // 
            // Rezervasyon_Kutusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.KoltukVeriLabel);
            this.Controls.Add(this.KoltukLabel);
            this.Controls.Add(this.DurumLabel);
            this.Controls.Add(this.IptalButonu);
            this.Controls.Add(this.FiyatVeriLabel);
            this.Controls.Add(this.FiyatLabel);
            this.Controls.Add(this.ÖdemeButonu);
            this.Controls.Add(this.SaatVeriLabel);
            this.Controls.Add(this.TarihVeriLabel);
            this.Controls.Add(this.RotaVeriLabel);
            this.Controls.Add(this.SaatLabel);
            this.Controls.Add(this.TarihLabel);
            this.Controls.Add(this.RotaLabel);
            this.Name = "Rezervasyon_Kutusu";
            this.Size = new System.Drawing.Size(241, 109);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FiyatVeriLabel;
        private System.Windows.Forms.Label FiyatLabel;
        public System.Windows.Forms.Button ÖdemeButonu;
        private System.Windows.Forms.Label SaatVeriLabel;
        private System.Windows.Forms.Label TarihVeriLabel;
        private System.Windows.Forms.Label RotaVeriLabel;
        private System.Windows.Forms.Label SaatLabel;
        private System.Windows.Forms.Label TarihLabel;
        private System.Windows.Forms.Label RotaLabel;
        public System.Windows.Forms.Button IptalButonu;
        private System.Windows.Forms.Label DurumLabel;
        private System.Windows.Forms.Label KoltukLabel;
        private System.Windows.Forms.Label KoltukVeriLabel;
    }
}
