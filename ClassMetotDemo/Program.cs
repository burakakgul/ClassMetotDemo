using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Burak";
            musteri1.Soyad = "Akgül";
            musteri1.Telefon = "05551112233";


            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Berat";
            musteri2.Soyad = "Akgül";
            musteri2.Telefon = "05351112233";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteriler[0]);
            musteriManager.MusteriEkle(musteriler[1]);

            musteriManager.MusteriSil(musteriler[0]);
            musteriManager.MusteriSil(musteriler[1]);

            musteriManager.MusteriListele(musteriler);
        }
    }
}
