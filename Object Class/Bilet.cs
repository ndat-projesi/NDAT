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
        public double BiletFiyati { get; set; }
        public bool IndirimUygulandiMi { get; set; }
        public bool GidisDonus { get; set; }

        // Constructor
        public Bilet(int biletId, double biletFiyati, bool indirimUygulandiMi, bool gidisDonus)
        {
            BiletId = biletId;
            BiletFiyati = biletFiyati;
            IndirimUygulandiMi = indirimUygulandiMi;
            GidisDonus = gidisDonus;
        }
    }
}
