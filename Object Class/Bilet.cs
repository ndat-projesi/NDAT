using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDAT
{
    public class Bilet
    {
        public int BiletId { get; set; }

        public int uyeID { get; set; }

        public uint ucusID { get; set; }
        public double BiletFiyati { get; set; }
        public bool IndirimUygulandiMi { get; set; }
        public bool GidisDonus { get; set; }

        // Constructor
        public Bilet(int biletId, Uye uye, Ucus ucus, double biletFiyati, bool indirimUygulandiMi, bool gidisDonus)
        {
            BiletId = biletId;
            uyeID = uye.UyeId;
            ucusID = ucus.UcusId;
            BiletFiyati = biletFiyati;
            IndirimUygulandiMi = indirimUygulandiMi;
            GidisDonus = gidisDonus;
        }
    }
}
