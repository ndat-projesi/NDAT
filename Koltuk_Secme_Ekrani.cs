using NDAT.Object_Class;
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
        private Koltuk seciliKoltuk;

        public Koltuk_Secme_Ekrani()
        {
            InitializeComponent();
            ComboBoxlariDoldur();
            KoltukListesiKutusu.Format += new ListControlConvertEventHandler(ComboBox_Format);
        }
        

        private void ComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            // Koltuk nesnesini al.
            Koltuk koltuk = e.ListItem as Koltuk;

            // Koltuk bilgilerini formatla (spaghetti)
            e.Value = $"{(koltuk.Tip == KoltukTipi.VIP ? "VIP " : "Normal ")} - {koltuk.KoltukKonum} - {(koltuk.Durum == KoltukDurumu.Bos ? " Boş" : (koltuk.Durum == KoltukDurumu.Rezerve ? " Rezerve" : " Dolu"))}";
        }
        
        private void ComboBoxlariDoldur()
        {
            KoltukListesiKutusu.DataSource = null;
            KoltukListesiKutusu.DataSource = Demo_Verileri.secilenUcus.Koltuklar;
            KoltukListesiKutusu.DisplayMember = "Display";
        }
        private void SatinAlButonu_Click(object sender, EventArgs e) // Satın Alma
        {
            if (seciliKoltuk.Durum != KoltukDurumu.Dolu)
            {
                // Koltuk fiyatını belirleyin
                decimal koltukFiyat = seciliKoltuk.Fiyat;

                // İndirimli fiyatı hesaplayın
                //double indirimliFiyat = Demo_Verileri.girisYapanUye.GetDiscountedPrice(koltukFiyat);

                // Koltuğun durumunu güncelleyin
                Demo_Verileri.secilenUcus.Koltuklar[seciliKoltuk.KoltukKonum].Durum = KoltukDurumu.Dolu;
                ComboBoxlariDoldur();

                // Kullanıcıya mesaj gösterin
                MessageBox.Show($"Üye Tipi: {Demo_Verileri.girisYapanUye.UyelikTipi}\nNormal Fiyat: {seciliKoltuk.Fiyat}\nİndirimli Fiyat:  TL", "Bilet Satın Alındı");
                
            }
            else
            {
                MessageBox.Show("Koltuk dolu durumda. Lütfen başka bir koltuk seçin.");
            }
        }
        private void RezerveButonu_Click(object sender, EventArgs e) // Rezervasyon
        {
            if (seciliKoltuk.Durum == KoltukDurumu.Bos)
            {
                Demo_Verileri.secilenUcus.Koltuklar[seciliKoltuk.KoltukKonum].Durum = KoltukDurumu.Rezerve;
                ComboBoxlariDoldur();
                Timer zamanlayici = new Timer
                {
                    Tag = seciliKoltuk.KoltukKonum,
                    Interval = 10000,
                };
                zamanlayici.Tick += RezervasyonTimer_Tick;
                zamanlayici.Start();
                MessageBox.Show("Koltuk 10 saniyeliğine rezerve edildi.");
            }
            else if (seciliKoltuk.Durum == KoltukDurumu.Rezerve)
            {
                MessageBox.Show("Koltuk zaten rezerve edildi. Lütfen başka bir koltuk seçin.");
            }
            else
            {
                MessageBox.Show("Koltuk zaten dolu durumda. Lütfen başka bir koltuk seçin.");
            }
        }
        private void RezervasyonTimer_Tick(object sender, EventArgs e)
        {
            Timer zamanlayici = sender as Timer;
            if (Demo_Verileri.secilenUcus.Koltuklar[int.Parse(zamanlayici.Tag.ToString())].Durum != KoltukDurumu.Dolu)
            {
                Demo_Verileri.secilenUcus.Koltuklar[int.Parse(zamanlayici.Tag.ToString())].Durum = KoltukDurumu.Bos;
                ComboBoxlariDoldur();
                zamanlayici.Dispose();
                MessageBox.Show("Rezervasyon süresi doldu. Koltuk tekrar boş durumda.");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliKoltuk = KoltukListesiKutusu.SelectedItem as Koltuk;
        }
    }
}
