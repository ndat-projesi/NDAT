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
        private List<Ucus> ucuslar;
        public Ucus_Secme_Ekrani(Uye uye)
        {
            InitializeComponent();

            // ComboBox'ları doldur.
            KalkisComboBox.Items.AddRange(new string[] { "Ankara", "İstanbul", "İzmir", "Antalya", "Van", "Trabzon", "Çanakkale", "Gaziantep" });
            VarisComboBox.Items.AddRange(new string[] { "Ankara", "İstanbul", "İzmir", "Antalya", "Van", "Trabzon", "Çanakkale", "Gaziantep" });
            
            // ComboBox'ların default değerlerini seç.
            KalkisComboBox.SelectedIndex = 0;
            VarisComboBox.SelectedIndex = 1;

            ucuslar = VeriUretici.HaftalikUcusListesiOlustur(0);
        }

        public void paneleUcusEkle(Ucus ucus)
        {
            Ucus_Kutusu yeni_kutu = new Ucus_Kutusu(ucus);

            yeni_kutu.UcusSecmeButonu.Click += (sender, e) =>
            { 
                Koltuk_Secme_Ekrani koltuk_Secme_Ekrani = new Koltuk_Secme_Ekrani();
                Hide();
                koltuk_Secme_Ekrani.Show();
            };

            // Paneli forma ekle.
            UcusPanel.Controls.Add(yeni_kutu);
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
            List<Ucus> bulunanUcuslar = ucuslar.FindAll(ucus =>
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
    }
}
