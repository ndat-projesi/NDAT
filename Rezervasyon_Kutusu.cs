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
    public partial class Rezervasyon_Kutusu : UserControl
    {
        private long rezID;
        private int koltukID;
        private uint ucusID;

        public Rezervasyon_Kutusu(Rezervasyon rezervasyon)
        {
            InitializeComponent();
            rezID = rezervasyon.RezId;
            koltukID = rezervasyon.koltukID;
            ucusID = rezervasyon.ucusID;
            Ucus ucus = Demo_Verileri.ucuslar.Find(u => u.UcusId == rezervasyon.ucusID);
            RotaVeriLabel.Text = ucus.KalkisYeri + " -> " + ucus.VarisYeri;
            TarihVeriLabel.Text = ucus.Tarih.ToShortDateString();
            SaatVeriLabel.Text = ucus.Tarih.ToShortTimeString();
            FiyatVeriLabel.Text = ucus.Koltuklar[0].Fiyat.ToString();
            KoltukVeriLabel.Text = rezervasyon.koltukID.ToString();

            switch (rezervasyon.Durum)
            {
                case RezervasyonDurumu.Onaylanmis:
                    DurumLabel.Text = "Ödendi";
                    butonGizle();
                    break;
                case RezervasyonDurumu.IptalEdilmis:
                    DurumLabel.Text = "İptal Edildi";
                    butonGizle();
                    break;
                case RezervasyonDurumu.Bekleyen:
                    DurumLabel.Text = "Bekliyor";
                    break;
            }
        }

        private void ÖdemeButonu_Click(object sender, EventArgs e)
        {
            if ((Demo_Verileri.rezervasyonlar.Find(u=> u.RezId.Equals(rezID)).Durum == RezervasyonDurumu.IptalEdilmis))
            {
                butonGizle();
                DurumLabel.Text = "İptal Edildi";
            }

            butonGizle();
            // Koltuğu doldur.
            Demo_Verileri.ucuslar.Find(u => u.UcusId == ucusID)
                         .Koltuklar.Find(u => u.koltukID == koltukID).Durum = KoltukDurumu.Dolu;

            // Rezervasyon durumunu güncelle.
            Demo_Verileri.rezervasyonlar.Find(u=> u.RezId == rezID).Durum = RezervasyonDurumu.Onaylanmis;
            DurumLabel.Text = "Ödendi";

            // Bilet oluştur.
        }

        private void IptalButonu_Click(object sender, EventArgs e)
        {
            butonGizle();

            // Koltuğu boşalt.
            Demo_Verileri.ucuslar.Find(u => u.UcusId == ucusID)
                         .Koltuklar.Find(u => u.koltukID == koltukID).Durum = KoltukDurumu.Bos;

            // Rezervasyon durumunu güncelle.
            Demo_Verileri.rezervasyonlar.Find(u => u.RezId == rezID).Durum = RezervasyonDurumu.IptalEdilmis;
            DurumLabel.Text = "İptal Edildi";
        }

        private void butonGizle()
        {
            ÖdemeButonu.Visible = false;
            IptalButonu.Visible = false;
            ÖdemeButonu.Enabled = false;
            IptalButonu.Enabled = false;
        }
    }
}
