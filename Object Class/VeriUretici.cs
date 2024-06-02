using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDAT
{
    internal static class VeriUretici
    {
        // Program her çalıştığında aynı değerleri üretir.
        private static Random rasgeleSayi = new Random(100);

        public static List<Ucus> HaftalikUcusListesiOlustur(uint id)
        {
            // Rasgele sayı üretici.
            DateTime baslangicTarihi = new DateTime(2024, 1, 1);

            // Şehir listesi.
            List<string> sehirler = new List<string> { "Ankara", "İstanbul", "İzmir", "Antalya", "Van", "Trabzon", "Çanakkale", "Gaziantep" };

            // Problemli şehirler.
            List<string> problemliSehirler = new List<string> { "Çanakkale", "Van", "Trabzon" };

            // Haftanın günleri.
            List<string> günler = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            // Problemli günler
            List<string> problemligünler = new List<string> { "Wednesday", "Sunday" };

            // Uçak tipi.
            List<string> ucakTipi = new List<string> { "Boeing 737", "Boeing 747", "Airbus A320", "Airbus A380", "Embraer E190", "Bombardier CRJ200", "McDonnell Douglas MD-80", "Fokker 100" };

            // Uçuş listesi.
            List<Ucus> ucuslar = new List<Ucus>();

            foreach (var kalkis in sehirler)
            {
                foreach (var varis in sehirler)
                {
                    if (varis == kalkis)
                    {
                        continue;
                    }
                    else if (problemliSehirler.Contains(kalkis) && problemliSehirler.Contains(varis))
                    {
                        for (int eklenecekGun = 2; eklenecekGun < 7; eklenecekGun += 4)
                        {
                            ucuslar.Add(new Ucus(id++, kalkis, varis, baslangicTarihi.AddDays(eklenecekGun).AddHours(8), ucakTipi[rasgeleSayi.Next(ucakTipi.Count)], KoltukOlustur(rasgeleSayi.Next(90,120))));
                            ucuslar.Add(new Ucus(id++, kalkis, varis, baslangicTarihi.AddDays(eklenecekGun).AddHours(22), ucakTipi[rasgeleSayi.Next(ucakTipi.Count)], KoltukOlustur(rasgeleSayi.Next(90, 120))));
                        }
                    }
                    else
                    {
                        for (int eklenecekGun = 0; eklenecekGun < 7; eklenecekGun++)
                        {
                            ucuslar.Add(new Ucus(id++, kalkis, varis, baslangicTarihi.AddDays(eklenecekGun).AddHours(10), ucakTipi[rasgeleSayi.Next(ucakTipi.Count)], KoltukOlustur(rasgeleSayi.Next(90, 120))));
                            ucuslar.Add(new Ucus(id++, kalkis, varis, baslangicTarihi.AddDays(eklenecekGun).AddHours(16), ucakTipi[rasgeleSayi.Next(ucakTipi.Count)], KoltukOlustur(rasgeleSayi.Next(90, 120))));
                            ucuslar.Add(new Ucus(id++, kalkis, varis, baslangicTarihi.AddDays(eklenecekGun).AddHours(22), ucakTipi[rasgeleSayi.Next(ucakTipi.Count)], KoltukOlustur(rasgeleSayi.Next(90, 120))));
                        }
                    }
                }
            }


            return ucuslar;
        }

        public static List<Koltuk> KoltukOlustur(int koltukSayisi)
        {
            // Uçak için koltuk fiyatı sabit bir değer.
            decimal fiyat = rasgeleSayi.Next(700, 1500);

            // Koltukların tutulduğu liste.
            List<Koltuk> koltuklar = new List<Koltuk>();

            for (int i = 0; i < 4; i++)
            {
                koltuklar.Add(new Koltuk(i, (KoltukDurumu)rasgeleSayi.Next(2), KoltukTipi.VIP, fiyat));
            }

            for (int i = 4; i < koltukSayisi; i++ )
            {
                koltuklar.Add(new Koltuk(i, (KoltukDurumu)rasgeleSayi.Next(2), KoltukTipi.Normal, fiyat));
            }

            return koltuklar;
        }
    }
}
