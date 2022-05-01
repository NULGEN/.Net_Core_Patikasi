using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("***** Implicit Conversion *****");
            byte aa = 5;
            sbyte bb = 30;
            short cc = 10;

            int d = aa + bb + cc;
            Console.WriteLine("d: " + d);

            long hh = d;
            Console.WriteLine("h: " + hh);

            float ii = hh;
            Console.WriteLine("i: " + ii);

            string e = "Zikriye";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g: " + g);

            //Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("***** Explicit Conversion *****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // ***** ToString Methodu *****
            Console.WriteLine("***** ToString Methodu *****");
            int sayi = 6;
            string yazi = sayi.ToString();
            Console.WriteLine("yy: " + yazi);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            //System.Convert
            Console.WriteLine("*****System.Covert sınıfı*****");
            string s1 = "10", s2 = "20";
            int sayi3, sayi4;
            int Toplam;

            sayi3 = Convert.ToInt32(s1);
            sayi4 = Convert.ToInt32(s2);

            Toplam = sayi3 + sayi4;
            Console.WriteLine("Toplam: " + Toplam);

            //Parse
            Console.WriteLine("***** Parse Methodu *****");
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("double1: " + double1);
        }
    }
}
