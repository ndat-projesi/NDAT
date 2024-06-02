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
        Dolu,
        Rezerve
    }

    public enum KoltukTipi
    {
        VIP,
        Normal
    }

    // Koltuk sınıfı
    public class Koltuk
    {
        public int KoltukKonum { get; set; }
        public KoltukDurumu Durum { get; set; }

        public KoltukTipi Tip { get; set; }

        public Koltuk(int koltukkonum, KoltukDurumu durum, KoltukTipi tip, decimal fiyat)
        {
            KoltukKonum = koltukkonum;
            Durum = durum;
            Fiyat = fiyat;
            Tip = tip;
        }
        public decimal Fiyat { get; set; }
    }
}
