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

        public static List<Uye> uyeler = new List<Uye>
            {
                new Uye(1, "Ahmet", "Yılmaz", "05001112233", "ahmet@gmail.com", DateTime.Now.AddYears(-2), "Normal"),
                new DaimiUye(2, "Mehmet", "Kaya", "05004445566", "mehmet@gmail.com", DateTime.Now.AddYears(-1), "Daimi", 10, 5),
                new VIPUye(3, "Ayşe", "Demir", "05007778899", "ayse@gmail.com", DateTime.Now.AddMonths(-6), "VİP", 20, 10)
            };

        public static List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

        public static List<Bilet> biletler = new List<Bilet>();
    }
}
