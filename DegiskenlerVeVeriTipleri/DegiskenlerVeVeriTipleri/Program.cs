using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenlerVeVeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 9;             //1 byte
            sbyte c = 8;            //1 byte

            short s = 2;            //2 byte
            ushort us = 3;          //2 byte

            Int16 i16 = 1;          //2 byte
            Int32 i32 = 1;          //4 byte
            Int64 i64 = 1;          //8 byte

            uint ui = 2;            //4 byte
            long l = 4;             //8 byte
            ulong ul = 4;           //8 byte

            //Reel sayılar
            float fl = 5;            //4 byte
            double db = 5.5;           //8 byte
            decimal de = 5.15M;         //16 byte

            char ch = '2';          //2 byte
            string str = "Ali";   //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 7.5;

            // string ifadeler
            string str1 = string.Empty;
            str1 = "Nilüfer Ülgen";
            string ad = "Nilüfer";
            string soyad = "Ülgen";
            string tamIsim = ad + " " + soyad;

            //integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean ifadeler
            bool bool1 = true;

            //Değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            //Datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
