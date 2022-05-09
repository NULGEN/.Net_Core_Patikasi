﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Soru 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
           (ArrayList sınıfını kullanara yazınız.)  Negatif ve numeric olmayan girişleri engelleyin.Her bir dizinin 
           elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın. Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/
           
            
            ArrayList asalSayi = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();
            Console.WriteLine("20 adet pozitif sayı girişi yapınız");
            int sayi;
          
            for (int i = 1; i <=20; i++)
            {
                Console.Write( i+". Sayıyı girin: ");
                string giris = Console.ReadLine();

                // *Negatif ve numeric olmayan girişleri engelleyin.
                if (int.TryParse(giris, out sayi)!=true || sayi<0)
                {
                    Console.WriteLine("Negatif veya numeric olmayan değer girdiniz.");
                    i--;
                    continue;                      
                }
                
                if (AsalMi(sayi)==true)
                {
                    asalSayi.Add(sayi);
                }
                else
                {
                    asalOlmayan.Add(sayi);
                }
                               
            }
                      

            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            Console.WriteLine("*********************************");
            Console.WriteLine("Asal Sayı Listesi");
            asalSayi.Sort();
            asalSayi.Reverse();

            foreach (var item in asalSayi)
            {
                Console.WriteLine(item );
            }
                       
            Console.WriteLine("*******************************");

            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/

            int asaltoplam = 0;

            foreach (int item in asalSayi)
            {
                asaltoplam += item;

            }

            Console.WriteLine("Asal sayı listesi eleman sayısı:  " + asalSayi.Count);
            Console.WriteLine("Asal sayı listesi ortalaması:  " + Math.Round((double)asaltoplam / (asalSayi.Count),2));
            Console.WriteLine();
           
            
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.

            Console.WriteLine("*******************************");
            Console.WriteLine("Asal olmayan sayı listesi: ");

            asalOlmayan.Sort();
            asalOlmayan.Reverse();

            foreach (var item in asalOlmayan)
            {
                Console.WriteLine(item);
            }

            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/

            Console.WriteLine("*******************************");

            int asalolmayantoplam = 0;
            foreach (int item in asalOlmayan)
            {
                asalolmayantoplam += item;
            }
            Console.WriteLine("Asal olmayan sayı listesi eleman sayısı:  " + asalOlmayan.Count);

            Console.WriteLine("Asal olmayan sayı listesi ortalaması:  " + Math.Round( (double)asalolmayantoplam / (asalOlmayan.Count),2));

                  
        }

        public static bool AsalMi(int number)
        {
            return AsalMi(number, 2);

        }
        public static bool AsalMi(int number, int i)
        {
            if (number==1)
            {
                return false;
            }

            if (number==i)
            {
                return true;
            }
            else
            {
                if (number%i == 0)
                {
                    return false;
                }
                else
                {
                    return AsalMi(number, i + 1);
                }
            }
        }



    }
}
