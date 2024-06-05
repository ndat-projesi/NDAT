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
    public partial class Ucus_Secme_Ekrani : Form
    {
        private int secilikoltukID;
        private uint seciliUcusID;
        public Ucus_Secme_Ekrani()
        {
            InitializeComponent();

            // ComboBox'ları doldur.
            KalkisComboBox.Items.AddRange(new string[] { "Ankara", "İstanbul", "İzmir", "Antalya", "Van", "Trabzon", "Çanakkale", "Gaziantep" });
            VarisComboBox.Items.AddRange(new string[] { "Ankara", "İstanbul", "İzmir", "Antalya", "Van", "Trabzon", "Çanakkale", "Gaziantep" });
            
            // ComboBox'ların default değerlerini seç.
            KalkisComboBox.SelectedIndex = 0;
            VarisComboBox.SelectedIndex = 1;

            KoltukListesiKutusu.Format += new ListControlConvertEventHandler(ComboBox_Format);
        }

        public void paneleUcusEkle(Ucus ucus)
        {
            Ucus_Kutusu yeni_kutu = new Ucus_Kutusu(ucus);

            yeni_kutu.UcusSecmeButonu.Click += (sender, e) =>
            {
                seciliUcusID = ucus.UcusId;
                UcusRotaLabel.Text = ucus.KalkisYeri + " -> " + ucus.VarisYeri;
                UcusTarihLabel.Text = ucus.Tarih.ToShortDateString();
                UcusSaatLabel.Text = ucus.Tarih.ToShortTimeString();
                ComboBoxlariDoldur();
                aktifEt();
            };

            // Paneli forma ekle.
            UcusPanel.Controls.Add(yeni_kutu);
        }

        public void aktifEt()
        {
            UcusRotaLabel.Visible = true;
            UcusTarihLabel.Visible = true;
            UcusSaatLabel.Visible = true;
            RezerveButonu.Enabled = true;
            SatinAlButonu.Enabled = true;
            KoltukListesiKutusu.Enabled = true;
        }

        private void ucusBulanamadiPaneli()
        {
            // Yeni panel oluştur.
            Panel panel = new Panel
            {
                Size = new Size(300, 80),
                Location = new Point(10, 10)
                
            };
            Label ucusBulunamadiLabel = new Label
            {
                Text = "Uçuş Bulunamadı!",
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 18
            };

            panel.Controls.Add(ucusBulunamadiLabel);

            // Paneli forma ekle.
            UcusPanel.Controls.Add(panel);
        }

        private void UcusBulButonu_Click(object sender, EventArgs e)
        {
            // Gösterilen uçuşları temizle.
            UcusPanel.Controls.Clear();

            // Uçuşları bul.
            List<Ucus> bulunanUcuslar = Demo_Verileri.ucuslar.FindAll(ucus =>
            {
                return ucus.KalkisYeri.Equals(KalkisComboBox.Text) &&
                       ucus.VarisYeri.Equals(VarisComboBox.Text) &&
                       ucus.Tarih.Date.Equals(GidisTarihSecici.Value.Date);
            });

            // Bulunan uçuşları panele ekle.
            if (bulunanUcuslar.Any())
            {
                bulunanUcuslar.ForEach(paneleUcusEkle);
            }
            else
            {
                ucusBulanamadiPaneli();
            }


        }

        private void ComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            // Koltuk nesnesini al.
            Koltuk koltuk = e.ListItem as Koltuk;

            // Koltuk bilgilerini formatla (spaghetti)
            e.Value = $"{(koltuk.Tip == KoltukTipi.VIP ? "VIP " : "Normal ")} - {koltuk.koltukID} - {(koltuk.Durum == KoltukDurumu.Bos ? " Boş" : (koltuk.Durum == KoltukDurumu.Rezerve ? " Rezerve" : " Dolu"))}";
        }

        private void ComboBoxlariDoldur()
        {
            KoltukListesiKutusu.DataSource = null;
            KoltukListesiKutusu.DataSource = Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(seciliUcusID)).Koltuklar;
            KoltukListesiKutusu.DisplayMember = "Display";
        }
        private void SatinAlButonu_Click(object sender, EventArgs e) // Satın Alma
        {
            if (Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(seciliUcusID)).Koltuklar.Find(u => u.koltukID.Equals(secilikoltukID)).Tip == KoltukTipi.VIP && Demo_Verileri.girisYapanUye.uyelikTipi != UyelikTipi.VIP)
            {
                MessageBox.Show("Bu koltuk VIP üyelere özeldir. Lütfen başka bir koltuk seçin.");
            }
            else if (Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(seciliUcusID)).Koltuklar.Find(u => u.koltukID.Equals(secilikoltukID)).Durum != KoltukDurumu.Dolu)
            {
                // Koltuk fiyatını belirle.
                decimal koltukFiyat = Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(seciliUcusID)).Koltuklar.Find(u => u.koltukID.Equals(secilikoltukID)).Fiyat;

                // İndirimli fiyatı hesapla.
                decimal indirimliFiyat = Demo_Verileri.girisYapanUye.indirimHesapla(Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(seciliUcusID)).Koltuklar.Find(u => u.koltukID.Equals(secilikoltukID)).Fiyat);

                // Koltuğun durumunu güncelle.
                Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(seciliUcusID)).Koltuklar.Find(u => u.koltukID.Equals(secilikoltukID)).Durum = KoltukDurumu.Dolu;
                ComboBoxlariDoldur();

                // Kullanıcıya mesaj göster.
                MessageBox.Show($"Normal Fiyat: {Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(seciliUcusID)).Koltuklar.Find(u => u.koltukID.Equals(secilikoltukID)).Fiyat}\nİndirimli Fiyat: {indirimliFiyat} TL", "Bilet Satın Alındı");

            }
            else
            {
                MessageBox.Show("Koltuk dolu durumda. Lütfen başka bir koltuk seçin.");
            }
        }
        private void RezerveButonu_Click(object sender, EventArgs e) // Rezervasyon
        {
            if (Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(seciliUcusID)).Koltuklar.Find(u => u.koltukID.Equals(secilikoltukID)).Tip == KoltukTipi.VIP && Demo_Verileri.girisYapanUye.uyelikTipi != UyelikTipi.VIP) 
            {
                MessageBox.Show("Bu koltuk VIP üyelere özeldir. Lütfen başka bir koltuk seçin.");
            }
            else if (Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(seciliUcusID)).Koltuklar.Find(u => u.koltukID.Equals(secilikoltukID)).Durum == KoltukDurumu.Bos)
            {
                Demo_Verileri.rezervasyonlar.Add(new Rezervasyon(DateTime.Now.Ticks, Demo_Verileri.girisYapanUye, Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(seciliUcusID)), secilikoltukID, DateTime.Now, RezervasyonDurumu.Bekleyen, DateTime.Now));
                Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(seciliUcusID)).Koltuklar.Find(u => u.koltukID.Equals(secilikoltukID)).Durum = KoltukDurumu.Rezerve;
                ComboBoxlariDoldur();
                Timer zamanlayici = new Timer { Interval = 61000 };
                zamanlayici.Tick += (send, a) => { ComboBoxlariDoldur(); Console.WriteLine("Aga bende de sorun yok."); zamanlayici.Dispose(); };
                zamanlayici.Start();   

                MessageBox.Show("Koltuk 60 saniyeliğine rezerve edildi.");
            }
            else if (Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(seciliUcusID)).Koltuklar.Find(u => u.koltukID.Equals(secilikoltukID)).Durum == KoltukDurumu.Rezerve)
            {
                MessageBox.Show("Koltuk zaten rezerve edildi. Lütfen başka bir koltuk seçin.");
            }
            else
            {
                MessageBox.Show("Koltuk zaten dolu durumda. Lütfen başka bir koltuk seçin.");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Koltuk gecici = KoltukListesiKutusu.SelectedItem as Koltuk;
            
            if (gecici != null)
            {
                secilikoltukID = gecici.koltukID;
            }
        }

    }
}
