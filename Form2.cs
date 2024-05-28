using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDAT
{
    public partial class Form2 : Form
    {
        private List<Ucus> ucuslar;
        public Ucus SecilenUcus { get; private set; }
        public Form2()
        {
            InitializeComponent();
            this.ucuslar = ucuslar;
            LoadComboBoxItems();

        }
        private void LoadComboBoxItems()
        {
            // Kalkış yerleri ekle
            foreach (var ucus in ucuslar)
            {
                if (!comboBox1.Items.Contains(ucus.KalkisYeri))
                {
                    comboBox1.Items.Add(ucus.KalkisYeri);
                }
            }

            // Varış yerleri ekle
            foreach (var ucus in ucuslar)
            {
                if (!comboBox2.Items.Contains(ucus.VarisYeri))
                {
                    comboBox2.Items.Add(ucus.VarisYeri);
                }
            }

            // Tarihler ekle
            dateTimePicker1.MinDate = ucuslar.Min(u => u.Tarih);
            dateTimePicker1.MaxDate = ucuslar.Max(u => u.Tarih);
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kalkisYeri = comboBox1.SelectedItem?.ToString();
            string varisYeri = comboBox2.SelectedItem?.ToString();
            DateTime tarih = dateTimePicker1.Value.Date;

            // Seçilen uçuşu al
            SecilenUcus = ucuslar.Find(u =>
                u.KalkisYeri == kalkisYeri &&
                u.VarisYeri == varisYeri &&
                u.Tarih.Date == tarih);

            if (SecilenUcus != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir uçuş seçin.", "Geçersiz Seçim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
