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
            this.UcusPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.UcusPanel.Location = new System.Drawing.Point(271, 25);
            this.UcusPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.UcusPanel.Name = "UcusPanel";
            this.UcusPanel.Size = new System.Drawing.Size(324, 243);
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
            // Ucus_Secme_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 276);
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
    }
}