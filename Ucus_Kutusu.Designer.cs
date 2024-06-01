namespace NDAT
{
    partial class Ucus_Kutusu
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
            this.RotaLabel = new System.Windows.Forms.Label();
            this.TarihLabel = new System.Windows.Forms.Label();
            this.SaatLabel = new System.Windows.Forms.Label();
            this.RotaVeriLabel = new System.Windows.Forms.Label();
            this.TarihVeriLabel = new System.Windows.Forms.Label();
            this.SaatVeriLabel = new System.Windows.Forms.Label();
            this.UcusSecmeButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RotaLabel
            // 
            this.RotaLabel.AutoSize = true;
            this.RotaLabel.Location = new System.Drawing.Point(3, 3);
            this.RotaLabel.Name = "RotaLabel";
            this.RotaLabel.Size = new System.Drawing.Size(33, 13);
            this.RotaLabel.TabIndex = 0;
            this.RotaLabel.Text = "Rota:";
            // 
            // TarihLabel
            // 
            this.TarihLabel.AutoSize = true;
            this.TarihLabel.Location = new System.Drawing.Point(3, 16);
            this.TarihLabel.Name = "TarihLabel";
            this.TarihLabel.Size = new System.Drawing.Size(34, 13);
            this.TarihLabel.TabIndex = 1;
            this.TarihLabel.Text = "Tarih:";
            // 
            // SaatLabel
            // 
            this.SaatLabel.AutoSize = true;
            this.SaatLabel.Location = new System.Drawing.Point(3, 29);
            this.SaatLabel.Name = "SaatLabel";
            this.SaatLabel.Size = new System.Drawing.Size(32, 13);
            this.SaatLabel.TabIndex = 2;
            this.SaatLabel.Text = "Saat:";
            // 
            // RotaVeriLabel
            // 
            this.RotaVeriLabel.AutoSize = true;
            this.RotaVeriLabel.Location = new System.Drawing.Point(42, 3);
            this.RotaVeriLabel.Name = "RotaVeriLabel";
            this.RotaVeriLabel.Size = new System.Drawing.Size(72, 13);
            this.RotaVeriLabel.TabIndex = 3;
            this.RotaVeriLabel.Text = "Value not set.";
            // 
            // TarihVeriLabel
            // 
            this.TarihVeriLabel.AutoSize = true;
            this.TarihVeriLabel.Location = new System.Drawing.Point(42, 16);
            this.TarihVeriLabel.Name = "TarihVeriLabel";
            this.TarihVeriLabel.Size = new System.Drawing.Size(68, 13);
            this.TarihVeriLabel.TabIndex = 4;
            this.TarihVeriLabel.Text = "Date not set.";
            // 
            // SaatVeriLabel
            // 
            this.SaatVeriLabel.AutoSize = true;
            this.SaatVeriLabel.Location = new System.Drawing.Point(42, 29);
            this.SaatVeriLabel.Name = "SaatVeriLabel";
            this.SaatVeriLabel.Size = new System.Drawing.Size(68, 13);
            this.SaatVeriLabel.TabIndex = 5;
            this.SaatVeriLabel.Text = "Time not set.";
            // 
            // UcusSecmeButonu
            // 
            this.UcusSecmeButonu.Location = new System.Drawing.Point(162, 54);
            this.UcusSecmeButonu.Name = "UcusSecmeButonu";
            this.UcusSecmeButonu.Size = new System.Drawing.Size(75, 23);
            this.UcusSecmeButonu.TabIndex = 6;
            this.UcusSecmeButonu.Text = "Seç";
            this.UcusSecmeButonu.UseVisualStyleBackColor = true;
            // 
            // Ucus_Kutusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.UcusSecmeButonu);
            this.Controls.Add(this.SaatVeriLabel);
            this.Controls.Add(this.TarihVeriLabel);
            this.Controls.Add(this.RotaVeriLabel);
            this.Controls.Add(this.SaatLabel);
            this.Controls.Add(this.TarihLabel);
            this.Controls.Add(this.RotaLabel);
            this.Name = "Ucus_Kutusu";
            this.Size = new System.Drawing.Size(240, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RotaLabel;
        private System.Windows.Forms.Label TarihLabel;
        private System.Windows.Forms.Label SaatLabel;
        private System.Windows.Forms.Label RotaVeriLabel;
        private System.Windows.Forms.Label TarihVeriLabel;
        private System.Windows.Forms.Label SaatVeriLabel;
        public System.Windows.Forms.Button UcusSecmeButonu;
    }
}
