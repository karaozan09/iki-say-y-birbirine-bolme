using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaftaucİkinciKısım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz:");
         int sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz:");
          int sayı2 = Convert.ToInt32(Console.ReadLine());

            if (sayı1 % sayı2 == 0)
            {
           Console.WriteLine("sayı1 sayı2'ye tam bölünür");
            }
            else
            {
                Console.WriteLine("sayı1 sayı2'ye tam bölünmez");
            }

           


            Console.ReadLine();
        }

    }
}
