using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time>=6 && time<11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time<=18)
            {
                Console.WriteLine("İyi günler");
            }
            else
            {
                Console.WriteLine("İyi akşamlar");
            }

            string sonuc = time <= 18 ? "İyi günler" : "İyi akşamlar";

            sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi günler" : "İyi akşamlar"; 

            Console.WriteLine(sonuc);
        }
    }
}
