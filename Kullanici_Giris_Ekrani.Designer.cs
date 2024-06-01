namespace NDAT
{
    partial class Kullanici_Giris_Ekrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.KullaniciLabel = new System.Windows.Forms.Label();
            this.KullaniciAdiKutusu = new System.Windows.Forms.TextBox();
            this.SifreLabel = new System.Windows.Forms.Label();
            this.SifreKutusu = new System.Windows.Forms.TextBox();
            this.GirisButonu = new System.Windows.Forms.Button();
            this.NormalKullaniciLabel = new System.Windows.Forms.Label();
            this.NormalDetayLabel = new System.Windows.Forms.Label();
            this.DaimiKullaniciLabel = new System.Windows.Forms.Label();
            this.DaimiDetayLabel = new System.Windows.Forms.Label();
            this.VIPDetayLabel = new System.Windows.Forms.Label();
            this.VIPKullaniciLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KullaniciLabel
            // 
            this.KullaniciLabel.Location = new System.Drawing.Point(12, 80);
            this.KullaniciLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KullaniciLabel.Name = "KullaniciLabel";
            this.KullaniciLabel.Size = new System.Drawing.Size(100, 23);
            this.KullaniciLabel.TabIndex = 0;
            this.KullaniciLabel.Text = "Kullanıcı Adı:";
            // 
            // KullaniciAdiKutusu
            // 
            this.KullaniciAdiKutusu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.KullaniciAdiKutusu.Location = new System.Drawing.Point(12, 105);
            this.KullaniciAdiKutusu.Margin = new System.Windows.Forms.Padding(2);
            this.KullaniciAdiKutusu.Name = "KullaniciAdiKutusu";
            this.KullaniciAdiKutusu.Size = new System.Drawing.Size(98, 20);
            this.KullaniciAdiKutusu.TabIndex = 1;
            // 
            // SifreLabel
            // 
            this.SifreLabel.Location = new System.Drawing.Point(13, 127);
            this.SifreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SifreLabel.Name = "SifreLabel";
            this.SifreLabel.Size = new System.Drawing.Size(99, 25);
            this.SifreLabel.TabIndex = 2;
            this.SifreLabel.Text = "Şifre:";
            // 
            // SifreKutusu
            // 
            this.SifreKutusu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SifreKutusu.Location = new System.Drawing.Point(12, 154);
            this.SifreKutusu.Margin = new System.Windows.Forms.Padding(2);
            this.SifreKutusu.Name = "SifreKutusu";
            this.SifreKutusu.Size = new System.Drawing.Size(98, 20);
            this.SifreKutusu.TabIndex = 3;
            this.SifreKutusu.UseSystemPasswordChar = true;
            // 
            // GirisButonu
            // 
            this.GirisButonu.Location = new System.Drawing.Point(145, 190);
            this.GirisButonu.Margin = new System.Windows.Forms.Padding(2);
            this.GirisButonu.Name = "GirisButonu";
            this.GirisButonu.Size = new System.Drawing.Size(56, 25);
            this.GirisButonu.TabIndex = 7;
            this.GirisButonu.Text = "Giriş";
            this.GirisButonu.UseVisualStyleBackColor = true;
            this.GirisButonu.Click += new System.EventHandler(this.GirisButonu_Click);
            // 
            // NormalKullaniciLabel
            // 
            this.NormalKullaniciLabel.AutoSize = true;
            this.NormalKullaniciLabel.Location = new System.Drawing.Point(12, 9);
            this.NormalKullaniciLabel.Name = "NormalKullaniciLabel";
            this.NormalKullaniciLabel.Size = new System.Drawing.Size(85, 13);
            this.NormalKullaniciLabel.TabIndex = 8;
            this.NormalKullaniciLabel.Text = "Normal Kullanıcı:";
            // 
            // NormalDetayLabel
            // 
            this.NormalDetayLabel.AutoSize = true;
            this.NormalDetayLabel.Location = new System.Drawing.Point(103, 9);
            this.NormalDetayLabel.Name = "NormalDetayLabel";
            this.NormalDetayLabel.Size = new System.Drawing.Size(70, 13);
            this.NormalDetayLabel.TabIndex = 9;
            this.NormalDetayLabel.Text = "Ahmet Yılmaz";
            // 
            // DaimiKullaniciLabel
            // 
            this.DaimiKullaniciLabel.AutoSize = true;
            this.DaimiKullaniciLabel.Location = new System.Drawing.Point(12, 30);
            this.DaimiKullaniciLabel.Name = "DaimiKullaniciLabel";
            this.DaimiKullaniciLabel.Size = new System.Drawing.Size(78, 13);
            this.DaimiKullaniciLabel.TabIndex = 10;
            this.DaimiKullaniciLabel.Text = "Daimi Kullanıcı:";
            // 
            // DaimiDetayLabel
            // 
            this.DaimiDetayLabel.AutoSize = true;
            this.DaimiDetayLabel.Location = new System.Drawing.Point(103, 30);
            this.DaimiDetayLabel.Name = "DaimiDetayLabel";
            this.DaimiDetayLabel.Size = new System.Drawing.Size(72, 13);
            this.DaimiDetayLabel.TabIndex = 11;
            this.DaimiDetayLabel.Text = "Mehmet Kaya";
            // 
            // VIPDetayLabel
            // 
            this.VIPDetayLabel.AutoSize = true;
            this.VIPDetayLabel.Location = new System.Drawing.Point(103, 51);
            this.VIPDetayLabel.Name = "VIPDetayLabel";
            this.VIPDetayLabel.Size = new System.Drawing.Size(60, 13);
            this.VIPDetayLabel.TabIndex = 13;
            this.VIPDetayLabel.Text = "Ayşe Demir";
            // 
            // VIPKullaniciLabel
            // 
            this.VIPKullaniciLabel.AutoSize = true;
            this.VIPKullaniciLabel.Location = new System.Drawing.Point(13, 51);
            this.VIPKullaniciLabel.Name = "VIPKullaniciLabel";
            this.VIPKullaniciLabel.Size = new System.Drawing.Size(69, 13);
            this.VIPKullaniciLabel.TabIndex = 14;
            this.VIPKullaniciLabel.Text = "VIP Kullanıcı:";
            // 
            // Kullanici_Giris_Ekrani
            // 
            this.AcceptButton = this.GirisButonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 226);
            this.Controls.Add(this.VIPKullaniciLabel);
            this.Controls.Add(this.VIPDetayLabel);
            this.Controls.Add(this.DaimiDetayLabel);
            this.Controls.Add(this.DaimiKullaniciLabel);
            this.Controls.Add(this.NormalDetayLabel);
            this.Controls.Add(this.NormalKullaniciLabel);
            this.Controls.Add(this.GirisButonu);
            this.Controls.Add(this.SifreKutusu);
            this.Controls.Add(this.SifreLabel);
            this.Controls.Add(this.KullaniciAdiKutusu);
            this.Controls.Add(this.KullaniciLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Kullanici_Giris_Ekrani";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KullaniciLabel;
        private System.Windows.Forms.TextBox KullaniciAdiKutusu;
        private System.Windows.Forms.Label SifreLabel;
        private System.Windows.Forms.TextBox SifreKutusu;
        private System.Windows.Forms.Button GirisButonu;
        private System.Windows.Forms.Label NormalKullaniciLabel;
        private System.Windows.Forms.Label NormalDetayLabel;
        private System.Windows.Forms.Label DaimiKullaniciLabel;
        private System.Windows.Forms.Label DaimiDetayLabel;
        private System.Windows.Forms.Label VIPDetayLabel;
        private System.Windows.Forms.Label VIPKullaniciLabel;
    }
}

