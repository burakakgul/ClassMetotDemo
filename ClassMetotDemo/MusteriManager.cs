using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" Müşterisi Eklendi");
            Console.WriteLine("----------");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " Müşteri Silindi");
            Console.WriteLine("----------");
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var item in musteriler)
            {
                Console.WriteLine("Müşteri: " + item.Ad);
                Console.WriteLine("Müşteri: " + item.Soyad);
                Console.WriteLine("Müşteri: " + item.Telefon);
                Console.WriteLine("----------");
            }

        }
    }
}
