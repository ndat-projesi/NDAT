using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDAT
{
    public enum UyelikTipi
    {
        Normal,
        Daimi,
        VIP
    }
    public class Uye
    {
        public int UyeId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime Uyeliktarihi { get; set; }
        public UyelikTipi uyelikTipi { get; set; }
        public Uye(int uyeId, string ad, string soyad, string telefon, string email, DateTime uyeliktarihi, UyelikTipi uyetipi)
        {
            UyeId = uyeId;
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
            Email = email;
            Uyeliktarihi = uyeliktarihi;
            uyelikTipi = uyetipi;
        }

        public virtual decimal indirimHesapla(decimal fiyat)
        {
            return fiyat;
        }
    }
    public class DaimiUye : Uye
    {
        public int YillikBiletSayisi { get; set; }
        public int IndirimSayisi { get; set; }

        public DaimiUye(int uyeId, string ad, string soyad, string telefon, string email, DateTime uyeliktarihi, UyelikTipi uyelikTipi, int yillikBiletSayisi, int indirimSayisi)
            : base(uyeId, ad, soyad, telefon, email, uyeliktarihi, uyelikTipi)
        {
            YillikBiletSayisi = yillikBiletSayisi;
            IndirimSayisi = indirimSayisi;
        }

        public override decimal indirimHesapla(decimal fiyat)
        {
            return fiyat * (decimal) 0.9;
        }
    }

    public class VIPUye : Uye
    {
        public int YillikBiletSayisi { get; set; }
        public int IndirimSayisi { get; set; }

        public VIPUye(int uyeId, string ad, string soyad, string telefon, string email, DateTime uyeliktarihi, UyelikTipi uyelikTipi, int yillikBiletSayisi, int indirimSayisi)
            : base(uyeId, ad, soyad, telefon, email, uyeliktarihi, uyelikTipi)
        {
            YillikBiletSayisi = yillikBiletSayisi;
            IndirimSayisi = indirimSayisi;
        }

        public override decimal indirimHesapla(decimal fiyat)
        {
            return fiyat * (decimal) 0.75;
        }
    }
}
