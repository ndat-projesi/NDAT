using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public int RezervasyonId { get; set; }

        public int uyeID { get; set; }
        
        public uint ucusID { get; set; }
        public DateTime Tarih { get; set; }
        public RezervasyonDurumu Durum { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

        // Constructor
        public Rezervasyon(int rezervasyonId, Uye uye, Ucus ucus, DateTime tarih, RezervasyonDurumu durum, DateTime olusturmaTarihi)
        {
            RezervasyonId = rezervasyonId;

            uyeID = uye.UyeId;
            ucusID = ucus.UcusId;
            Tarih = tarih;
            Durum = durum;
            OlusturmaTarihi = olusturmaTarihi;
        }
    }
}
