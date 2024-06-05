namespace NDAT
{
    partial class Ucus_Secme_Ekrani
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
            this.KalkisSehriLabel = new System.Windows.Forms.Label();
            this.VarisSehriLabel = new System.Windows.Forms.Label();
            this.TarihLabel = new System.Windows.Forms.Label();
            this.KalkisComboBox = new System.Windows.Forms.ComboBox();
            this.VarisComboBox = new System.Windows.Forms.ComboBox();
            this.GidisTarihSecici = new System.Windows.Forms.DateTimePicker();
            this.UcusPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UcusBulButonu = new System.Windows.Forms.Button();
            this.RezerveButonu = new System.Windows.Forms.Button();
            this.SatinAlButonu = new System.Windows.Forms.Button();
            this.KoltukSecLabel = new System.Windows.Forms.Label();
            this.KoltukListesiKutusu = new System.Windows.Forms.ComboBox();
            this.BilgiLabel = new System.Windows.Forms.Label();
            this.UcusRotaLabel = new System.Windows.Forms.Label();
            this.UcusTarihLabel = new System.Windows.Forms.Label();
            this.UcusSaatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KalkisSehriLabel
            // 
            this.KalkisSehriLabel.AutoSize = true;
            this.KalkisSehriLabel.Location = new System.Drawing.Point(12, 9);
            this.KalkisSehriLabel.Name = "KalkisSehriLabel";
            this.KalkisSehriLabel.Size = new System.Drawing.Size(65, 13);
            this.KalkisSehriLabel.TabIndex = 0;
            this.KalkisSehriLabel.Text = "Kalkış Şehri:";
            // 
            // VarisSehriLabel
            // 
            this.VarisSehriLabel.AutoSize = true;
            this.VarisSehriLabel.Location = new System.Drawing.Point(136, 9);
            this.VarisSehriLabel.Name = "VarisSehriLabel";
            this.VarisSehriLabel.Size = new System.Drawing.Size(60, 13);
            this.VarisSehriLabel.TabIndex = 1;
            this.VarisSehriLabel.Text = "Varış Şehri:";
            // 
            // TarihLabel
            // 
            this.TarihLabel.AutoSize = true;
            this.TarihLabel.Location = new System.Drawing.Point(12, 49);
            this.TarihLabel.Name = "TarihLabel";
            this.TarihLabel.Size = new System.Drawing.Size(62, 13);
            this.TarihLabel.TabIndex = 2;
            this.TarihLabel.Text = "Gidiş Tarihi:";
            // 
            // KalkisComboBox
            // 
            this.KalkisComboBox.FormattingEnabled = true;
            this.KalkisComboBox.Location = new System.Drawing.Point(12, 25);
            this.KalkisComboBox.Name = "KalkisComboBox";
            this.KalkisComboBox.Size = new System.Drawing.Size(121, 21);
            this.KalkisComboBox.TabIndex = 3;
            // 
            // VarisComboBox
            // 
            this.VarisComboBox.FormattingEnabled = true;
            this.VarisComboBox.Location = new System.Drawing.Point(139, 25);
            this.VarisComboBox.Name = "VarisComboBox";
            this.VarisComboBox.Size = new System.Drawing.Size(121, 21);
            this.VarisComboBox.TabIndex = 4;
            // 
            // GidisTarihSecici
            // 
            this.GidisTarihSecici.Location = new System.Drawing.Point(12, 65);
            this.GidisTarihSecici.MaxDate = new System.DateTime(2024, 1, 7, 0, 0, 0, 0);
            this.GidisTarihSecici.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.GidisTarihSecici.Name = "GidisTarihSecici";
            this.GidisTarihSecici.Size = new System.Drawing.Size(200, 20);
            this.GidisTarihSecici.TabIndex = 6;
            this.GidisTarihSecici.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // UcusPanel
            // 
            this.UcusPanel.AutoScroll = true;
            this.UcusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UcusPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.UcusPanel.Location = new System.Drawing.Point(271, 9);
            this.UcusPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.UcusPanel.Name = "UcusPanel";
            this.UcusPanel.Size = new System.Drawing.Size(265, 259);
            this.UcusPanel.TabIndex = 10;
            this.UcusPanel.WrapContents = false;
            // 
            // UcusBulButonu
            // 
            this.UcusBulButonu.Location = new System.Drawing.Point(185, 245);
            this.UcusBulButonu.Name = "UcusBulButonu";
            this.UcusBulButonu.Size = new System.Drawing.Size(75, 23);
            this.UcusBulButonu.TabIndex = 11;
            this.UcusBulButonu.Text = "Ucuş Bul";
            this.UcusBulButonu.UseVisualStyleBackColor = true;
            this.UcusBulButonu.Click += new System.EventHandler(this.UcusBulButonu_Click);
            // 
            // RezerveButonu
            // 
            this.RezerveButonu.Enabled = false;
            this.RezerveButonu.Location = new System.Drawing.Point(542, 112);
            this.RezerveButonu.Margin = new System.Windows.Forms.Padding(2);
            this.RezerveButonu.Name = "RezerveButonu";
            this.RezerveButonu.Size = new System.Drawing.Size(56, 19);
            this.RezerveButonu.TabIndex = 15;
            this.RezerveButonu.Text = "Rezerve Et";
            this.RezerveButonu.UseVisualStyleBackColor = true;
            this.RezerveButonu.Click += new System.EventHandler(this.RezerveButonu_Click);
            // 
            // SatinAlButonu
            // 
            this.SatinAlButonu.Enabled = false;
            this.SatinAlButonu.Location = new System.Drawing.Point(626, 112);
            this.SatinAlButonu.Margin = new System.Windows.Forms.Padding(2);
            this.SatinAlButonu.Name = "SatinAlButonu";
            this.SatinAlButonu.Size = new System.Drawing.Size(56, 19);
            this.SatinAlButonu.TabIndex = 14;
            this.SatinAlButonu.Text = "Satın Al";
            this.SatinAlButonu.UseVisualStyleBackColor = true;
            this.SatinAlButonu.Click += new System.EventHandler(this.SatinAlButonu_Click);
            // 
            // KoltukSecLabel
            // 
            this.KoltukSecLabel.AutoSize = true;
            this.KoltukSecLabel.Location = new System.Drawing.Point(542, 72);
            this.KoltukSecLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KoltukSecLabel.Name = "KoltukSecLabel";
            this.KoltukSecLabel.Size = new System.Drawing.Size(77, 13);
            this.KoltukSecLabel.TabIndex = 13;
            this.KoltukSecLabel.Text = "Koltuk Seçiniz:";
            // 
            // KoltukListesiKutusu
            // 
            this.KoltukListesiKutusu.Enabled = false;
            this.KoltukListesiKutusu.FormattingEnabled = true;
            this.KoltukListesiKutusu.Location = new System.Drawing.Point(542, 87);
            this.KoltukListesiKutusu.Margin = new System.Windows.Forms.Padding(2);
            this.KoltukListesiKutusu.Name = "KoltukListesiKutusu";
            this.KoltukListesiKutusu.Size = new System.Drawing.Size(140, 21);
            this.KoltukListesiKutusu.TabIndex = 12;
            this.KoltukListesiKutusu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.KoltukListesiKutusu.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBox_Format);
            // 
            // BilgiLabel
            // 
            this.BilgiLabel.AutoSize = true;
            this.BilgiLabel.Location = new System.Drawing.Point(542, 9);
            this.BilgiLabel.Name = "BilgiLabel";
            this.BilgiLabel.Size = new System.Drawing.Size(73, 13);
            this.BilgiLabel.TabIndex = 16;
            this.BilgiLabel.Text = "Seçilen Uçuş:";
            // 
            // UcusRotaLabel
            // 
            this.UcusRotaLabel.AutoSize = true;
            this.UcusRotaLabel.Location = new System.Drawing.Point(542, 28);
            this.UcusRotaLabel.Name = "UcusRotaLabel";
            this.UcusRotaLabel.Size = new System.Drawing.Size(83, 13);
            this.UcusRotaLabel.TabIndex = 18;
            this.UcusRotaLabel.Text = "Uçuş Seçilmedi.";
            // 
            // UcusTarihLabel
            // 
            this.UcusTarihLabel.AutoSize = true;
            this.UcusTarihLabel.Location = new System.Drawing.Point(542, 41);
            this.UcusTarihLabel.Name = "UcusTarihLabel";
            this.UcusTarihLabel.Size = new System.Drawing.Size(0, 13);
            this.UcusTarihLabel.TabIndex = 19;
            this.UcusTarihLabel.Visible = false;
            // 
            // UcusSaatLabel
            // 
            this.UcusSaatLabel.AutoSize = true;
            this.UcusSaatLabel.Location = new System.Drawing.Point(542, 54);
            this.UcusSaatLabel.Name = "UcusSaatLabel";
            this.UcusSaatLabel.Size = new System.Drawing.Size(0, 13);
            this.UcusSaatLabel.TabIndex = 20;
            this.UcusSaatLabel.Visible = false;
            // 
            // Ucus_Secme_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 276);
            this.Controls.Add(this.UcusSaatLabel);
            this.Controls.Add(this.UcusTarihLabel);
            this.Controls.Add(this.UcusRotaLabel);
            this.Controls.Add(this.BilgiLabel);
            this.Controls.Add(this.RezerveButonu);
            this.Controls.Add(this.SatinAlButonu);
            this.Controls.Add(this.KoltukSecLabel);
            this.Controls.Add(this.KoltukListesiKutusu);
            this.Controls.Add(this.UcusBulButonu);
            this.Controls.Add(this.UcusPanel);
            this.Controls.Add(this.GidisTarihSecici);
            this.Controls.Add(this.VarisComboBox);
            this.Controls.Add(this.KalkisComboBox);
            this.Controls.Add(this.TarihLabel);
            this.Controls.Add(this.VarisSehriLabel);
            this.Controls.Add(this.KalkisSehriLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Ucus_Secme_Ekrani";
            this.Text = "Ucus_Secme_Ekrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KalkisSehriLabel;
        private System.Windows.Forms.Label VarisSehriLabel;
        private System.Windows.Forms.Label TarihLabel;
        private System.Windows.Forms.ComboBox KalkisComboBox;
        private System.Windows.Forms.ComboBox VarisComboBox;
        private System.Windows.Forms.DateTimePicker GidisTarihSecici;
        private System.Windows.Forms.FlowLayoutPanel UcusPanel;
        private System.Windows.Forms.Button UcusBulButonu;
        private System.Windows.Forms.Button RezerveButonu;
        private System.Windows.Forms.Button SatinAlButonu;
        private System.Windows.Forms.Label KoltukSecLabel;
        private System.Windows.Forms.ComboBox KoltukListesiKutusu;
        private System.Windows.Forms.Label BilgiLabel;
        private System.Windows.Forms.Label UcusRotaLabel;
        private System.Windows.Forms.Label UcusTarihLabel;
        private System.Windows.Forms.Label UcusSaatLabel;
    }
}