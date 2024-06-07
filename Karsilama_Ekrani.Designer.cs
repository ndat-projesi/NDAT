namespace NDAT
{
    partial class Karsilama_Ekrani
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
            this.UcusPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RezervasyonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BiletlerLabel = new System.Windows.Forms.Label();
            this.RezervasyonlarLabel = new System.Windows.Forms.Label();
            this.CikisButonu = new System.Windows.Forms.Button();
            this.YeniBiletButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UcusPanel
            // 
            this.UcusPanel.AutoScroll = true;
            this.UcusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UcusPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.UcusPanel.Location = new System.Drawing.Point(12, 32);
            this.UcusPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.UcusPanel.Name = "UcusPanel";
            this.UcusPanel.Size = new System.Drawing.Size(265, 259);
            this.UcusPanel.TabIndex = 11;
            this.UcusPanel.WrapContents = false;
            // 
            // RezervasyonPanel
            // 
            this.RezervasyonPanel.AutoScroll = true;
            this.RezervasyonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RezervasyonPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RezervasyonPanel.Location = new System.Drawing.Point(401, 32);
            this.RezervasyonPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.RezervasyonPanel.Name = "RezervasyonPanel";
            this.RezervasyonPanel.Size = new System.Drawing.Size(265, 259);
            this.RezervasyonPanel.TabIndex = 12;
            this.RezervasyonPanel.WrapContents = false;
            // 
            // BiletlerLabel
            // 
            this.BiletlerLabel.AutoSize = true;
            this.BiletlerLabel.Location = new System.Drawing.Point(12, 9);
            this.BiletlerLabel.Name = "BiletlerLabel";
            this.BiletlerLabel.Size = new System.Drawing.Size(56, 13);
            this.BiletlerLabel.TabIndex = 13;
            this.BiletlerLabel.Text = "Biletleriniz:";
            // 
            // RezervasyonlarLabel
            // 
            this.RezervasyonlarLabel.AutoSize = true;
            this.RezervasyonlarLabel.Location = new System.Drawing.Point(398, 9);
            this.RezervasyonlarLabel.Name = "RezervasyonlarLabel";
            this.RezervasyonlarLabel.Size = new System.Drawing.Size(98, 13);
            this.RezervasyonlarLabel.TabIndex = 14;
            this.RezervasyonlarLabel.Text = "Rezervasyonlarınız:";
            // 
            // CikisButonu
            // 
            this.CikisButonu.Location = new System.Drawing.Point(283, 268);
            this.CikisButonu.Name = "CikisButonu";
            this.CikisButonu.Size = new System.Drawing.Size(112, 23);
            this.CikisButonu.TabIndex = 15;
            this.CikisButonu.Text = "Çıkış Yap";
            this.CikisButonu.UseVisualStyleBackColor = true;
            this.CikisButonu.Click += new System.EventHandler(this.CikisButonu_Click);
            // 
            // YeniBiletButon
            // 
            this.YeniBiletButon.Location = new System.Drawing.Point(283, 32);
            this.YeniBiletButon.Name = "YeniBiletButon";
            this.YeniBiletButon.Size = new System.Drawing.Size(112, 23);
            this.YeniBiletButon.TabIndex = 16;
            this.YeniBiletButon.Text = "Yeni Bilet Al";
            this.YeniBiletButon.UseVisualStyleBackColor = true;
            this.YeniBiletButon.Click += new System.EventHandler(this.YeniBiletButon_Click);
            // 
            // Karsilama_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 302);
            this.Controls.Add(this.YeniBiletButon);
            this.Controls.Add(this.CikisButonu);
            this.Controls.Add(this.RezervasyonlarLabel);
            this.Controls.Add(this.BiletlerLabel);
            this.Controls.Add(this.RezervasyonPanel);
            this.Controls.Add(this.UcusPanel);
            this.Name = "Karsilama_Ekrani";
            this.Text = "Karşılama Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel UcusPanel;
        private System.Windows.Forms.FlowLayoutPanel RezervasyonPanel;
        private System.Windows.Forms.Label BiletlerLabel;
        private System.Windows.Forms.Label RezervasyonlarLabel;
        private System.Windows.Forms.Button CikisButonu;
        private System.Windows.Forms.Button YeniBiletButon;
    }
}