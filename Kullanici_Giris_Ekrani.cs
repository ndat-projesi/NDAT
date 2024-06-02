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
    public partial class Kullanici_Giris_Ekrani : Form
    {
        // Demo için üye listesi.
        private List<Uye> uyeler = new List<Uye>
            {
                new Uye(1, "Ahmet", "Yılmaz", "05001112233", "ahmet@gmail.com", DateTime.Now.AddYears(-2), "Normal"),
                new DaimiUye(2, "Mehmet", "Kaya", "05004445566", "mehmet@gmail.com", DateTime.Now.AddYears(-1), "Daimi", 10, 5),
                new VIPUye(3, "Ayşe", "Demir", "05007778899", "ayse@gmail.com", DateTime.Now.AddMonths(-6), "VİP", 20, 10)
            };

        public Kullanici_Giris_Ekrani()
        {
            InitializeComponent();
        }

        private void GirisButonu_Click(object sender, EventArgs e)
        {
            // Eğer eşleşme olursa "uye" değişkenine uye bilgilerini atıyoruz.
            Uye uye = uyeler.Find(u =>
                                  u.Ad.Equals(KullaniciAdiKutusu.Text, StringComparison.OrdinalIgnoreCase) &&
                                  u.Soyad.Equals(SifreKutusu.Text, StringComparison.OrdinalIgnoreCase)
            );

            if (uye != null)
            {
                // Giriş yapan kullanıcıyı kaydet.
                Demo_Verileri.girisYapanUye = uye;

                // Uçuş seçme ekranını göster.
                Ucus_Secme_Ekrani ucusSecmeEkrani = new Ucus_Secme_Ekrani();
                Hide();
                ucusSecmeEkrani.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre geçersiz.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
