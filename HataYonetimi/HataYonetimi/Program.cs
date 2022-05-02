using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());

                Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Hatalı giriş yapıldı"+ ex.Message.ToString());
            }
            finally // opsiyonel. Her şartta bu blok çalışır.
            {
                Console.WriteLine("İşlem Tamamlandı");
            }

            try
            {
               // int a = int.Parse(null); // ArgumentNull Exception
               // int a= int.Parse("test"); // Format Exception
                int b = int.Parse("-200000000000"); // Overflow Exception
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);            
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarı ile tamamlandı");
            }
            
            
            
            
           
        }
    }
}
