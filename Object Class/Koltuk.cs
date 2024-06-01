using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDAT
{
    public enum KoltukDurumu
    {
        Bos,
        Rezerve,
        Dolu
    }

    // Koltuk sınıfı
    public class Koltuk
    {
        public int KoltukId { get; set; }
        public KoltukDurumu Durum { get; set; }
        public string Konum { get; set; }

        // Constructor
        public Koltuk(int koltukId, KoltukDurumu durum, decimal fiyat)
        {
            KoltukId = koltukId;
            Durum = durum;
            Fiyat = fiyat;
        }
        public decimal Fiyat { get; set; }
        public bool KoltukDurumu { get; set; }
    }
}
