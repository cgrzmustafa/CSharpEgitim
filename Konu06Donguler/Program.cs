using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu06Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //For Döngüsü
            Console.WriteLine("For Döngüsü");
            int toplam = 0;
            int length = 10;
            for (int i = 0; i < length; i++)
            {
                toplam += i;
                Console.WriteLine("i değişkeninin değeri {0} toplamın değeri {1}",i, toplam);
            }
            Console.WriteLine("Toplam : " + toplam);
            */


            //While Döngüsü
            Console.WriteLine("While Döngüsü");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("While sayı {0}", i);//toplamın değerini ekrana yazdırıyoruz
                i++;//toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program
            }

            Console.Read();

        }
    }
}
