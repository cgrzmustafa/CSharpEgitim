using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu02TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Veri tipi dönüşümleri (Casting)
            int sayi1 = 123;
            long sayi2;
            sayi2 = sayi1; // İsstemsiz dönüşüm(implicit)

            long sayi3 = 1478945736;
            sayi1 = (int)sayi3; // Daha büyük bir veri tipinden daha küçük bir veri tipine dönüşüm yapmak 
            // istersek değerin önüne paratez içinde dönüştürmek istediğimiz veri tipini (explicit) dönüşüm
            // denir. 
            // NOT: Bu tür dönüşümler yalnızca sayısal veriler için yapılabilir string ya da bool tipleri
            // arasında yapılmaz.


            //Implicit Casting - otomatik dönüşüm
            //char -> int -> long -> float -> double
            //Explicit Casting - manuel
            //double -> float -> long -> int -> char

            Console.WriteLine("İmplicit Casting");
            int sayi = 18;
            double kesirliSayi = sayi; //intden double a otomatik dönüşüm


            Console.WriteLine(sayi);
            Console.WriteLine(kesirliSayi);
            Console.WriteLine();

            Console.WriteLine("Explicit Casting");
            double kesirliSayi2 = 18.8;
            int tamsayi = (int)kesirliSayi2; // Manuel dönüştürme

            Console.WriteLine(tamsayi);
            Console.WriteLine(kesirliSayi2);
            Console.WriteLine();


            //Diğer Tür Dönüştürme Yöntemleri
            //Convert.ToBoolean Convert.ToDouble Convert.ToString Convert.ToInt32 int Convert.ToInt64 long
            int tamsayi2 = 10;
            double kesirliSayi3 = 5.25;
            bool islemSonuc = true;

            Console.WriteLine(Convert.ToString(tamsayi2)); // convert int to string
            Console.WriteLine(Convert.ToDouble(tamsayi2)); // convert int to double
            Console.WriteLine(Convert.ToInt32(kesirliSayi3)); // convert double to int
            Console.WriteLine(Convert.ToString(islemSonuc));  // convert bool to string



            Console.Read();



        }
    }
}
