using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDAT
{
    public class Odeme
    {
        public int UcusId { get; set; }
        public int UyeId { get; set; }
        public int KoltukId { get; set; }

        // Constructor
        public Odeme(int ucusId, int uyeId, int koltukId)
        {
            UcusId = ucusId;
            UyeId = uyeId;
            KoltukId = koltukId;
        }
    }
}
