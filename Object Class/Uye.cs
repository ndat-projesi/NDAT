using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDAT
{
    public class Uye
    {
        public int UyeId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime Uyeliktarihi { get; set; }
        public string UyelikTipi { get; set; }
        public Uye(int uyeId, string ad, string soyad, string telefon, string email, DateTime uyeliktarihi, string uyelikTipi)
        {
            UyeId = uyeId;
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
            Email = email;
            Uyeliktarihi = uyeliktarihi;
            UyelikTipi = uyelikTipi;
        }
    }
    public class DaimiUye : Uye
    {
        public int YillikBiletSayisi { get; set; }
        public int IndirimSayisi { get; set; }

        public DaimiUye(int uyeId, string ad, string soyad, string telefon, string email, DateTime uyeliktarihi, string uyelikTipi, int yillikBiletSayisi, int indirimSayisi)
            : base(uyeId, ad, soyad, telefon, email, uyeliktarihi, uyelikTipi)
        {
            YillikBiletSayisi = yillikBiletSayisi;
            IndirimSayisi = indirimSayisi;
        }
    }

    public class VIPUye : Uye
    {
        public int YillikBiletSayisi { get; set; }
        public int IndirimSayisi { get; set; }

        public VIPUye(int uyeId, string ad, string soyad, string telefon, string email, DateTime uyeliktarihi, string uyelikTipi, int yillikBiletSayisi, int indirimSayisi)
            : base(uyeId, ad, soyad, telefon, email, uyeliktarihi, uyelikTipi)
        {
            YillikBiletSayisi = yillikBiletSayisi;
            IndirimSayisi = indirimSayisi;
        }
    }
}
