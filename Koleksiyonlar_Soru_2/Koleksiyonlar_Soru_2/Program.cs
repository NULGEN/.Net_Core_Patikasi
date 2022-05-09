﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
             * her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama 
             * toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)*/
            ArrayList Sayilar = new ArrayList();
            ArrayList BuyukSayi = new ArrayList();
            ArrayList KucukSayi = new ArrayList();
            
            Console.WriteLine("20 adet pozitif sayı girişi yapınız");
            int sayi;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i + ". Sayıyı girin: ");
                string giris = Console.ReadLine();

                // *Negatif ve numeric olmayan girişleri engelleyin.
                if (int.TryParse(giris, out sayi) != true || sayi < 0)
                {
                    Console.WriteLine("Negatif veya numeric olmayan değer girdiniz.");
                    i--;
                    continue;
                }
                Sayilar.Add(i);

            }
            Sayilar.Sort();

            for (int i = 0; i < Sayilar.Count; i++)
            {
                if (i>=3)
                {
                    
                    break;
                }
                KucukSayi.Add(Sayilar[i]);
            }
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine("En kucuk 3 sayı: ");

            foreach (int item in KucukSayi)
            {
                Console.WriteLine(item);
            }


            Sayilar.Reverse();
            for (int i = 0; i < Sayilar.Count; i++)
            {
                if (i>=3)
                {
                    break;                    
                }
                BuyukSayi.Add(Sayilar[i]);
            }
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine("En buyuk 3 sayı: ");

            foreach (int item in BuyukSayi)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();

            Console.WriteLine("**********************");

            int BuyukSayiToplam = 0;

            foreach (int item in BuyukSayi)
            {
                BuyukSayiToplam += item;
            }
            double BuyukSayiOrtalama = Math.Round((double)(BuyukSayiToplam / BuyukSayi.Count), 2);

            Console.Write("Buyuk sayı dizisi toplamı: " + BuyukSayiToplam+("  ")+"Buyuk sayı dizisi ortalaması: " + BuyukSayiOrtalama);

            Console.WriteLine();

            Console.WriteLine("**********************");

            int KucukSayiToplam = 0;

            foreach (int item in KucukSayi)
            {
                KucukSayiToplam += item;
            }
            double KucukSayiOrtalama = Math.Round((double)(KucukSayiToplam / KucukSayi.Count), 2);

            Console.WriteLine("Kucuk sayı dizisi toplamı: " + KucukSayiToplam+("  " )+" Kucuk sayı dizisi ortalaması: " +KucukSayiOrtalama );

            Console.WriteLine();

            Console.WriteLine("**********************");

            Console.WriteLine("Dizlerin Ortalama Toplamı= "+ (BuyukSayiOrtalama+KucukSayiOrtalama));
        }
    }
}
