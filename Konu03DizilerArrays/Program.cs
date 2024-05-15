using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu03DizilerArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi oluşturma 
            int[] sayi; // veri tipini belirttikten sonra köşeli parantez koyup dizi ismini vererek dizimizi oluşturmuş oluyoruz.
            int[] ogrenciler = new int[7]; //ogrenciler isminde int veri tipi taşıyan ve 7 elemandan oluşan bir dizi oluşturduk
            //Dizilerde indis denilen yapı vardır ve içine eklenecek elemanlar 0 dan başlar.

            ogrenciler[0] = 100;
            ogrenciler[1] = 200;
            ogrenciler[2] = 200;
            ogrenciler[3] = 300;
            ogrenciler[4] = 400;
            ogrenciler[5] = 500;
            ogrenciler[6] = 600;
            //ogrenciler[7] = 600;
            //Dizilere başlangıçta kaç elemandan oluşacağı tanımlanmışsa o sayının dışına çıkarsak hata alırız.
            ogrenciler[5] = 550;

            Console.WriteLine(ogrenciler[5]);

            string[] isimler = new string[5];
            isimler[0] = "Mustafa";
            isimler[1] = "Murat";
            isimler[2] = "Taner";
            isimler[3] = "Halil";
            isimler[4] = "Ahmet";

            Console.WriteLine(isimler[3]);


            int[] ogrenciler2 = { 100, 200, 300, 400, 500 }; /*Bir diğer dizi oluşturma yöntemi, bu yöntemde diziye kaç elemandan oluşacağı bilgisi verilmez
                                                             ve değerler diziye eklenir. Bu durumda dizi kaç elemandan oluştuğunu içine elemanları sayarak kendisi
                                                             bilir*/
            Console.WriteLine(ogrenciler2[0]);

            ogrenciler2[0] = 118;

            Console.WriteLine(ogrenciler2[0]);


            string[] isimler2 = { "Mustafa", "Murat", "Taner" };
            Console.WriteLine(isimler2[2]);
            isimler2[2] = "Ahmet";
            Console.WriteLine(isimler2[2]);

            //Diğer dizi türleri

            //İki boyutlu diziler
            int[,] arr2boyut; //2 boyutlu dizi oluşturma

            int[,] ikilSayi = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine(ikilSayi[0, 0]+ "\t");
            Console.WriteLine(ikilSayi[0, 1] + "\t");
            Console.WriteLine(ikilSayi[1, 0] + "\t");
            Console.WriteLine(ikilSayi[1, 1] + "\t");
            Console.WriteLine(ikilSayi[2, 0] + "\t");
            Console.WriteLine(ikilSayi[2, 1] + "\t");

            //Üç boyutlu diziler
            int[,,] arr3boyut;

            //Dört boyutlu diziler
            int[,,] arr4boyut;

            Console.Read();
        }
    }
}
