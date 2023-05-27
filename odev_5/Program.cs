using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int toplam = 0;
            
            while (sayi > 0)
            {
                toplam += sayi % 10;
                sayi /= 10;
            }

            Console.WriteLine("Sonuç : " + toplam);
            Console.ReadKey();
        }

    }
}
