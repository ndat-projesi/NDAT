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
    
    public partial class Form3 : Form
    {
        private List<Koltuk> vipKoltuklar = new List<Koltuk>();
        private List<Koltuk> normalKoltuklar = new List<Koltuk>();
        private Timer rezervasyonTimer = new Timer();
        private Koltuk seciliKoltuk;
        private Uye uye;

        public Form3(Uye uye)
        {

            InitializeComponent();
            KoltuklariOlustur();
            ComboBoxlariDoldur();
            rezervasyonTimer.Interval = 600; // 1 dakika
            rezervasyonTimer.Tick += RezervasyonTimer_Tick;
            comboBox1.Format += new ListControlConvertEventHandler(ComboBox_Format);
            comboBox2.Format += new ListControlConvertEventHandler(ComboBox_Format);
            this.uye = uye;
        }
        
        private Uye GirisYapanKullanici(int uyeId)
        {
            // Kullanıcı listesi
            List<Uye> kullanicilar = new List<Uye>
            {
                new Uye(1, "Ahmet", "Yılmaz", "05001112233", "ahmet@gmail.com", DateTime.Now.AddYears(-2), UyeTipi.Normal),
                new DaimiUye(2, "Mehmet", "Kaya", "05004445566", "mehmet@gmail.com", DateTime.Now.AddYears(-1), UyeTipi.Daimi, 10, 5),
                new VIPUye(3, "Ayşe", "Demir", "05007778899", "ayse@gmail.com", DateTime.Now.AddMonths(-6), UyeTipi.VIP, 20, 10)
            };

            return kullanicilar.FirstOrDefault(u => u.UyeId == uyeId);
        }

        private void ComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            // Koltuk nesnesini al
            var koltuk = e.ListItem as Koltuk;
            // Koltuk bilgilerini formatla
            e.Value = $"{koltuk.Konum} - {(koltuk.Durum == KoltukDurumu.Bos ? "Boş" : "Dolu")}";
        }
        private void KoltuklariOlustur()
        {
            for (int i = 1; i <= 4; i++)
            {
                vipKoltuklar.Add(new VIPKoltuk(i, KoltukDurumu.Bos, $"VIP {i}"));
            }
            for (int i = 1; i <= 20; i++)
            {
                normalKoltuklar.Add(new NormalKoltuk(i, KoltukDurumu.Bos, $"Normal {i}"));
            }
        }
        private void ComboBoxlariDoldur()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = vipKoltuklar;
            comboBox1.DisplayMember = "Display";

            comboBox2.DataSource = null;
            comboBox2.DataSource = normalKoltuklar;
            comboBox2.DisplayMember = "Display";
        }
        private void button1_Click(object sender, EventArgs e) // Satın Alma
        {
            if (seciliKoltuk != null && seciliKoltuk.Durum == KoltukDurumu.Bos)
            {

                if (uye.UyeId == 1)
                {
                    Uye girisYapan = GirisYapanKullanici(1); // Bu ID normalde giriş yapan kullanıcıdan alınır

                    // Koltuk fiyatını belirleyin
                    double koltukFiyat = seciliKoltuk is VIPKoltuk ? 500.0 : 200.0;

                    // İndirimli fiyatı hesaplayın
                    double indirimliFiyat = girisYapan.GetDiscountedPrice(koltukFiyat);

                    // Koltuğun durumunu güncelleyin
                    seciliKoltuk.Durum = KoltukDurumu.Dolu;
                    ComboBoxlariDoldur();

                    // Kullanıcıya mesaj gösterin
                    MessageBox.Show($"Üye Tipi: {girisYapan.UyelikTipi}\nİndirimli Fiyat: {indirimliFiyat} TL", "Bilet Satın Alındı");
                }
                if (uye.UyeId == 2)
                {
                    Uye girisYapan = GirisYapanKullanici(2); // Bu ID normalde giriş yapan kullanıcıdan alınır

                    // Koltuk fiyatını belirleyin
                    double koltukFiyat = seciliKoltuk is VIPKoltuk ? 500.0 : 200.0;

                    // İndirimli fiyatı hesaplayın
                    double indirimliFiyat = girisYapan.GetDiscountedPrice(koltukFiyat);

                    // Koltuğun durumunu güncelleyin
                    seciliKoltuk.Durum = KoltukDurumu.Dolu;
                    ComboBoxlariDoldur();

                    // Kullanıcıya mesaj gösterin
                    MessageBox.Show($"Üye Tipi: {girisYapan.UyelikTipi}\nİndirimli Fiyat: {indirimliFiyat} TL", "Bilet Satın Alındı");
                }
                if (uye.UyeId == 3)
                {
                    Uye girisYapan = GirisYapanKullanici(3); // Bu ID normalde giriş yapan kullanıcıdan alınır

                    // Koltuk fiyatını belirleyin
                    double koltukFiyat = seciliKoltuk is VIPKoltuk ? 500.0 : 200.0;

                    // İndirimli fiyatı hesaplayın
                    double indirimliFiyat = girisYapan.GetDiscountedPrice(koltukFiyat);

                    // Koltuğun durumunu güncelleyin
                    seciliKoltuk.Durum = KoltukDurumu.Dolu;
                    ComboBoxlariDoldur();

                    // Kullanıcıya mesaj gösterin
                    MessageBox.Show($"Üye Tipi: {girisYapan.UyelikTipi}\nİndirimli Fiyat: {indirimliFiyat} TL", "Bilet Satın Alındı");
                }


            }
        }
        private void button2_Click(object sender, EventArgs e) // Rezervasyon
        {
            if (seciliKoltuk != null && seciliKoltuk.Durum == KoltukDurumu.Bos)
            {
                seciliKoltuk.Durum = KoltukDurumu.Dolu;
                ComboBoxlariDoldur();
                rezervasyonTimer.Start();
                MessageBox.Show("Koltuk 1 dakikalığına rezerve edildi.");
            }
        }
        private void RezervasyonTimer_Tick(object sender, EventArgs e)
        {
            if (seciliKoltuk != null && seciliKoltuk.Durum == KoltukDurumu.Dolu)
            {
                seciliKoltuk.Durum = KoltukDurumu.Bos;
                ComboBoxlariDoldur();
                rezervasyonTimer.Stop();
                MessageBox.Show("Rezervasyon süresi doldu. Koltuk tekrar boş durumda.");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliKoltuk = comboBox1.SelectedItem as Koltuk;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliKoltuk = comboBox2.SelectedItem as Koltuk;
        }
    

    }


        

    // Seçilen Normal koltuk

    
    

    

    



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
