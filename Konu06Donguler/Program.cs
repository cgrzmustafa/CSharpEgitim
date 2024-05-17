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

            /*
            //While Döngüsü
            Console.WriteLine("While Döngüsü");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("While sayı {0}", i);//toplamın değerini ekrana yazdırıyoruz
                i++;//toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program
            }
            */

            /*
            //Do While Döngüsü
            Console.WriteLine("Do While Döngüsü");
            int toplam = 2;
            do
            {
                Console.WriteLine("do while sayı {0}",toplam); // toplamın değerini ekrana yazdırıyoruz
                toplam++; //toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program
            } while (toplam < 10);
            */

            /*
            string[] isimler2 = { "Mustafa", "Murat", "Taner" };
            int[] ogrenciler2 = { 100, 200, 300, 400, 500 };
            Console.WriteLine("Foreach Döngüsü");
            foreach (var item in isimler2)
            {
                Console.WriteLine("Öğrenci Adı : " + item);
            }
            foreach (var item in ogrenciler2)
            {
                Console.WriteLine("Öğrenci No : " + item);
            }
            */

            /*
            Console.WriteLine("İç içe for döngüsü");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i değişkeninin değeri {0}", i);
                for (global::System.Int32 j = 0; j < 3; j++)
                {
                    Console.WriteLine("\t j değişkeninin değeri {0}", j);
                }
            }
            */

            string[] isimler2 = { "Mustafa", "Murat", "Taner" };
            int[] ogrenciler2 = { 100, 200, 300, 400, 500 };

            Console.WriteLine("iç içe foreach döngüsü");
            foreach (var isim in isimler2)
            {
                Console.WriteLine("Öğrenci Adı : "+ isim);
                foreach (var ogrencino in ogrenciler2)
                {
                    Console.WriteLine("     Öğrenci No : " + ogrencino);
                }
            }


            Console.Read();




        }
    }
}
