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
    public partial class Koltuk_Secme_Ekrani : Form
    {
        private List<Koltuk> vipKoltuklar;
        private List<Koltuk> normalKoltuklar;
        public Koltuk_Secme_Ekrani()
        {

            InitializeComponent();
            InitializeKoltuklar();
            LoadComboBoxes();
        }
        private void InitializeKoltuklar()
        {
            
        }
        private void LoadComboBoxes()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            // VIP Koltuklar için ComboBox
            foreach (var koltuk in vipKoltuklar)
            {
                if (!koltuk.KoltukDurumu)
                {
                    comboBox1.Items.Add(koltuk);
                }
            }

            // Normal Koltuklar için ComboBox
            foreach (var koltuk in normalKoltuklar)
            {
                if (!koltuk.KoltukDurumu)
                {
                    comboBox2.Items.Add(koltuk);
                }
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            // Seçilen VIP koltuk
            if (comboBox1.SelectedItem != null)
            {
                
                Koltuk selectedKoltuk = comboBox1.SelectedItem as Koltuk;
                

                if (selectedKoltuk.Durum ==  KoltukDurumu.Bos)
                {
                    selectedKoltuk.Durum = KoltukDurumu.Dolu;
                    MessageBox.Show($"{selectedKoltuk.Konum} koltuğu başarıyla seçildi.");
                }
                else
                {
                    MessageBox.Show($"{selectedKoltuk.Konum} koltuğu zaten dolu.");
                }
            }

            // Seçilen Normal koltuk
            if (comboBox2.SelectedItem != null)
            {
                Koltuk selectedKoltuk = comboBox2.SelectedItem as Koltuk;


                if (selectedKoltuk.Durum == KoltukDurumu.Bos)
                {
                    selectedKoltuk.Durum = KoltukDurumu.Dolu;
                    MessageBox.Show($"{selectedKoltuk.Konum} koltuğu başarıyla seçildi.");
                }
                else
                {
                    MessageBox.Show($"{selectedKoltuk.Konum} koltuğu zaten dolu.");
                }
            }

            // Seçimden sonra ComboBox'ları güncelle
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            LoadComboBoxes();
            this.Hide();
            Odeme_Ekrani mainForm = new Odeme_Ekrani();

            mainForm.Show();
        }
    }
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
   
}
