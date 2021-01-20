using System;
using System.Collections.Generic;
using System.Text;


namespace ClassMetotDemo
{
    public class MusteriManager
    {

        public static void Listele(Musteri m)
        {
            Console.WriteLine("Müşteri Listesi");


        }

        public static void Ekle (Musteri m)
        {
            
            Console.WriteLine(m.Ad + " " + m.Soyad + "Müşteri Eklendi");

        }

        public static void Guncelle (Musteri m)
        {

            Console.WriteLine("Müşteri Bilgileri Güncellendi");
        }



        public static void Sil(Musteri m)
        {

            Console.WriteLine(m.Ad+" "+m.Soyad+"İsimli Müşteri Silindi");
        }
    }
}
