using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu05KosulYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int sayi = -10;
            if (sayi > 0) //Eğer sayı 0 dan büyükse
            {
                Console.WriteLine("sayı pzoitiftir");
            }
            else if (sayi == 0) //Sayı 0 a eşitse
            {
                Console.WriteLine("sayı sıfırdır");
            }
            else //Sayı 0 dan küçükse
            {
                Console.WriteLine("sayı negatiftir");
            }*/

            /*
            Console.WriteLine("Kullanıcı Adınızı Giriniz");
            string KullaniciAdi = Console.ReadLine();//Console.ReadLine(); metodu ekrandan girilen değeri yakalar ve KullaniciAdi değişkenine atar

            Console.WriteLine("Şifrenizi Giriniz");
            string Sifre = Console.ReadLine();//Console.ReadLine(); metodu ekrandan girilen değeri yakalar ve Sifre değişkenine atar

            string veritabanindakiKullaniciAdi = "admin";
            string veritabanindakiSifre = "123456";

            if (KullaniciAdi == veritabanindakiKullaniciAdi && Sifre == veritabanindakiSifre)
            {
                Console.WriteLine("Sisteme giriş yapıldı");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifrenizde hata var!");
            }
            */

            /*
            Console.WriteLine("Yaşınızı giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());//Console.ReadLine() metodu ekrandan aldığı veriyi string tipinde bize dödürür, convert metoduyla sayısal string veriyi int e çevirebiliriz

            string ogrenim = "ilkokul";

            if (yas >= 18)
            {
                if (ogrenim == "lise" ||  ogrenim == "üniversite") Console.WriteLine("Ehliyet alabilirsiniz.");
                else Console.WriteLine("Öğrenim durumunuz ehliyet içi yeterli değil");
            }
            else Console.WriteLine("Ehliyet için yaşınız tutmuyor");
            */

            //Console.WriteLine("1 ile 12 arasında bir sayı giriniz :");
            int ay = DateTime.Now.Month; //Convert.ToInt32(Console.ReadLine());
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimi");
                    break;
                case 6: 
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Mevsimi");
                    break;
                default:
                    Console.WriteLine("Yanlış Bilgi.");
                    break;
            }


            Console.Read();


        }
    }
}
