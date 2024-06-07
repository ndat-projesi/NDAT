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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace NDAT
{
    public partial class Karsilama_Ekrani : Form
    {
        Timer timer = new Timer
        {
            Interval = 5000
        };

        public Karsilama_Ekrani()
        {
            InitializeComponent();
            rezervasyonListele();
            timer.Tick += (sender, e) => { rezervasyonListele(); };
            timer.Start();
        }

        private void YeniBiletButon_Click(object sender, EventArgs e)
        {
            // Uçuş seçme ekranını göster.
            Ucus_Secme_Ekrani ucusSecmeEkrani = new Ucus_Secme_Ekrani();
            Hide();
            ucusSecmeEkrani.FormClosed += new FormClosedEventHandler(ucusSecmeEkrani_Closed);
            ucusSecmeEkrani.Show();
        }

        private void ucusSecmeEkrani_Closed(object sender, FormClosedEventArgs e)
        {
            rezervasyonListele();
            Show();
        }

        private void CikisButonu_Click(object sender, EventArgs e)
        {
            timer.Dispose();
            Close();
        }

        private void rezervasyonListele()
        {
            // Gösterilen rezervasyonları temizle.
            RezervasyonPanel.Controls.Clear();
                
            if (Demo_Verileri.girisYapanUye == null) { return; }

                // Rezervasyonları bul.
                List<Rezervasyon> bulunanRezervasyonlar = Demo_Verileri.rezervasyonlar.FindAll(rez =>
                {
                    Console.WriteLine(rez.uyeID + rez.koltukID);
                    return rez.uyeID.Equals(Demo_Verileri.girisYapanUye.UyeId);
                });

                // Bulunan uçuşları panele ekle.
                if (bulunanRezervasyonlar.Any())
                {
                    bulunanRezervasyonlar.ForEach(rezervasyonEkle);
                
                }
                else
                {
                    Label label = new Label();
                    label.Text = "Rezervasyonunuz bulunmamaktadır.";
                    label.AutoSize = true;
                    RezervasyonPanel.Controls.Add(label);
                }
            

        }

        private void rezervasyonEkle(Rezervasyon rezervasyon)
        {
            Console.WriteLine("Bir kere çağrılması lazım.");
            Rezervasyon_Kutusu rezervasyon_Kutusu = new Rezervasyon_Kutusu(rezervasyon);
            RezervasyonPanel.Controls.Add(rezervasyon_Kutusu);
        }
    }
}
