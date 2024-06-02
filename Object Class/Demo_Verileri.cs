using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDAT.Object_Class
{
    internal static class Demo_Verileri
    {
        // Uçuşlar program açıldığında oluşturulur.
        public static List<Ucus> ucuslar = VeriUretici.HaftalikUcusListesiOlustur(0);

        // Giriş yapan kullanıcı, "Kullanici_Giris_Ekrani" formunda belirlenir.
        public static Uye girisYapanUye = null;

        // Seçilen uçuş bilgisi, "Ucus_Secme_Ekrani" formunda belirlenir.
        public static Ucus secilenUcus = null;
    }
}
