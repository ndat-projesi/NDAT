namespace NDAT
{
    partial class Koltuk_Secme_Ekrani
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
            this.KoltukListesiKutusu = new System.Windows.Forms.ComboBox();
            this.KoltukSecLabel = new System.Windows.Forms.Label();
            this.SatinAlButonu = new System.Windows.Forms.Button();
            this.RezerveButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KoltukListesiKutusu
            // 
            this.KoltukListesiKutusu.FormattingEnabled = true;
            this.KoltukListesiKutusu.Location = new System.Drawing.Point(14, 24);
            this.KoltukListesiKutusu.Margin = new System.Windows.Forms.Padding(2);
            this.KoltukListesiKutusu.Name = "KoltukListesiKutusu";
            this.KoltukListesiKutusu.Size = new System.Drawing.Size(140, 21);
            this.KoltukListesiKutusu.TabIndex = 0;
            this.KoltukListesiKutusu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // KoltukSecLabel
            // 
            this.KoltukSecLabel.AutoSize = true;
            this.KoltukSecLabel.Location = new System.Drawing.Point(11, 9);
            this.KoltukSecLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KoltukSecLabel.Name = "KoltukSecLabel";
            this.KoltukSecLabel.Size = new System.Drawing.Size(77, 13);
            this.KoltukSecLabel.TabIndex = 1;
            this.KoltukSecLabel.Text = "Koltuk Seçiniz:";
            // 
            // SatinAlButonu
            // 
            this.SatinAlButonu.Location = new System.Drawing.Point(98, 49);
            this.SatinAlButonu.Margin = new System.Windows.Forms.Padding(2);
            this.SatinAlButonu.Name = "SatinAlButonu";
            this.SatinAlButonu.Size = new System.Drawing.Size(56, 19);
            this.SatinAlButonu.TabIndex = 4;
            this.SatinAlButonu.Text = "Satın Al";
            this.SatinAlButonu.UseVisualStyleBackColor = true;
            this.SatinAlButonu.Click += new System.EventHandler(this.SatinAlButonu_Click);
            // 
            // RezerveButonu
            // 
            this.RezerveButonu.Location = new System.Drawing.Point(14, 49);
            this.RezerveButonu.Margin = new System.Windows.Forms.Padding(2);
            this.RezerveButonu.Name = "RezerveButonu";
            this.RezerveButonu.Size = new System.Drawing.Size(56, 19);
            this.RezerveButonu.TabIndex = 5;
            this.RezerveButonu.Text = "Rezerve Et";
            this.RezerveButonu.UseVisualStyleBackColor = true;
            this.RezerveButonu.Click += new System.EventHandler(this.RezerveButonu_Click);
            // 
            // Koltuk_Secme_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 83);
            this.Controls.Add(this.RezerveButonu);
            this.Controls.Add(this.SatinAlButonu);
            this.Controls.Add(this.KoltukSecLabel);
            this.Controls.Add(this.KoltukListesiKutusu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Koltuk_Secme_Ekrani";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox KoltukListesiKutusu;
        private System.Windows.Forms.Label KoltukSecLabel;
        private System.Windows.Forms.Button SatinAlButonu;
        private System.Windows.Forms.Button RezerveButonu;
    }
}