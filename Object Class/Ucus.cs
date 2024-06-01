using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDAT
{
    public class Ucus
    {
        public uint UcusId { get; set; }
        public string KalkisYeri { get; set; }
        public string VarisYeri { get; set; }
        public DateTime Tarih { get; set; }
        public string UcakTipi { get; set; }
        public List<Koltuk> Koltuklar { get; set; }

        // Constructor
        public Ucus(uint ucusId, string kalkisYeri, string varisYeri, DateTime tarih, string ucakTipi, List<Koltuk> koltuklar)
        {
            UcusId = ucusId;
            KalkisYeri = kalkisYeri;
            VarisYeri = varisYeri;
            Tarih = tarih;
            UcakTipi = ucakTipi;
            Koltuklar = koltuklar;
        }
    }
}
