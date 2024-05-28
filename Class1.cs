﻿using System;
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

       

        public override string ToString()
        {
            return $"{Ad} {Soyad} ({UyelikTipi})";
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


















    public class Ucus
    {
        public int UcusId { get; set; }
        public string KalkisYeri { get; set; }
        public string VarisYeri { get; set; }
        public DateTime Tarih { get; set; }
        public string UcakTipi { get; set; }
        public string HaftalikUcusGunleri { get; set; }
        public int KoltukSayisi { get; set; }

        // Constructor
        public Ucus(int ucusId, string kalkisYeri, string varisYeri, DateTime tarih, string ucakTipi, string haftalikUcusGunleri, int koltukSayisi)
        {
            UcusId = ucusId;
            KalkisYeri = kalkisYeri;
            VarisYeri = varisYeri;
            Tarih = tarih;
            
            UcakTipi = ucakTipi;
            HaftalikUcusGunleri = haftalikUcusGunleri;
            KoltukSayisi = koltukSayisi;
        }

        public override string ToString()
        {
            return $"Flight ID: {UcusId}, From: {KalkisYeri}, To: {VarisYeri}, Date: {Tarih.ToShortDateString()}, Aircraft Type: {UcakTipi}, Weekly Flights: {HaftalikUcusGunleri}, Seats: {KoltukSayisi}";
        }
    }
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









    public enum KoltukDurumu
    {
        Bos,
        Dolu
    }

    // Koltuk sınıfı
    public class Koltuk
    {
        public int KoltukId { get; set; }
        public KoltukDurumu Durum { get; set; }
        public string Tip { get; set; }
        public string Konum { get; set; }

        // Constructor
        public Koltuk(int koltukId, KoltukDurumu durum, string tip, string konum)
        {
            KoltukId = koltukId;
            Durum = durum;
            Tip = tip;
            Konum = konum;
        }
    }















    public enum RezervasyonDurumu
    {
        Bekleyen,
        Onaylanmis,
        IptalEdilmis
    }

    // Rezervasyon sınıfı
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public DateTime Tarih { get; set; }
        public RezervasyonDurumu Durum { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

        // Constructor
        public Rezervasyon(int rezervasyonId, DateTime tarih, RezervasyonDurumu durum, DateTime olusturmaTarihi)
        {
            RezervasyonId = rezervasyonId;
            Tarih = tarih;
            Durum = durum;
            OlusturmaTarihi = olusturmaTarihi;
        }
    }
























































}