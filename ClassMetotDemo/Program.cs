using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriTc = "11111111111";
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriSoyadi = "Kale";
            musteri1.MusteriAdres = "Efeler/Aydın";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriTc = "22222222222";
            musteri2.MusteriAdi = "Mehmet";
            musteri2.MusteriSoyadi = "Güzel";
            musteri2.MusteriAdres = "Eyüp/İstanbul";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriTc = "33333333333";
            musteri3.MusteriAdi = "Ayşe";
            musteri3.MusteriSoyadi = "Yıldırım";
            musteri3.MusteriAdres = "Fatih/İstanbul";

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.Add(musteri1);

            musteriManager.Delete(musteri2);

            musteriManager.Guncelle(musteri3);

            musteriManager.GetAll(musteriler);
        }

        
    }
}
