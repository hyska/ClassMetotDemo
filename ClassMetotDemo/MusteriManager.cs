using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " Eklendi");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " Silindi");
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " Güncellendi");
        }
        public void GetAll(Musteri[] musteriler)
        {
            Console.WriteLine("~~~~Müşteri Listeleme~~~~" );
            foreach (var musteri in musteriler) { 
                Console.WriteLine("ID : " + musteri.Id);
                Console.WriteLine("Tc : " + musteri.MusteriTc);
                Console.WriteLine("Ad : " + musteri.MusteriAdi);
                Console.WriteLine("Soyadı : " + musteri.MusteriSoyadi);
                Console.WriteLine("Adres : " + musteri.MusteriAdres);
                Console.WriteLine("~~~~~~~~~~");
            }
        }
    }
}
