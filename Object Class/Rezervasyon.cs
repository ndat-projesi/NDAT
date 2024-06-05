using NDAT.Object_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NDAT
{
    public enum RezervasyonDurumu
    {
        Bekleyen,
        Onaylanmis,
        IptalEdilmis
    }

    // Rezervasyon sınıfı
    public class Rezervasyon
    {
        public long RezId { get; set; }

        public int uyeID { get; set; }

        public uint ucusID { get; set; }

        public int koltukID { get; set; }
        public DateTime Tarih { get; set; }
        public RezervasyonDurumu Durum { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

        public Timer zamanlayici { get; set; }

        // Constructor
        public Rezervasyon(long rezervasyonId, Uye uye, Ucus ucus, int koltukid, DateTime tarih, RezervasyonDurumu durum, DateTime olusturmaTarihi)
        {
            RezId = rezervasyonId;

            uyeID = uye.UyeId;
            ucusID = ucus.UcusId;
            koltukID = koltukid;
            Tarih = tarih;
            Durum = durum;
            OlusturmaTarihi = olusturmaTarihi;

            zamanlayici = new Timer(zamanlayici_Tick, rezervasyonId, 60000, 0);
            Demo_Verileri.rezervasyonlar.Add(this);
        }

        private void zamanlayici_Tick(object state)
        {
            if (Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(ucusID)).Koltuklar.Find(u => u.koltukID.Equals(koltukID)).Durum != KoltukDurumu.Dolu)
            {
                Demo_Verileri.rezervasyonlar.RemoveAll(u=> u.RezId.Equals(RezId));
                Demo_Verileri.ucuslar.Find(u => u.UcusId.Equals(ucusID)).Koltuklar.Find(u => u.koltukID.Equals(koltukID)).Durum = KoltukDurumu.Bos;
            }
            zamanlayici.Dispose();
        }
    }

}

