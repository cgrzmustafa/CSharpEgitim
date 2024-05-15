using System;

namespace Konu01Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# ta değişken tanımlama
            // C# ta değişken tanımlamak için önce değişkenin veri tipi sonra ismi yazılıp ; ile kod satırı sonlandırılır.
            // veri tipi ilgili değişkenin hangi türde veri alabileceeğini belirler mesela tamsayı veya kesirli sayı gibi. veya alabileceği maksimum değer 
            // stack ve heap

            //Tamsayı veri türleri
            byte plaka_kodu = 255; // 0 - 255 arası tamsayı
            sbyte Sbyteturu = 127; // -128 ile 127 arasında
            short kisa = 32767; // -32768 ile 32767 arasıda
            ushort birazuzun = 65535; // 0 ile 65535 arasında
            int plaka2 = 2147483647;  // 32 bit 4 byte  +2147483647  , -2147483648
            uint uzunint = 4294967295u; // 0 ile 4294967295u arasında
            long bayauzun = 9223372036854775807L; // -9223372036854775808L ile 9223372036854775807L

            // Kesirli sayı değişken tipleri
            float kesirliSayi = 4.5f; // 4 byte yer kaplar 6-7 basamak ve kullanırken f harfini unutma!
            double kesirliSayi2 = 4.5; // 8 byte yer kaplar 15-16 basamak

            // Decimal veri tipi
            decimal UrunFiyati = 5500; // 12 byte, duyarlı basamak 28-29 basamak , hassas işlemler

            // Char veri tipi
            char karakter = 'ç'; // char sadece 1 tane değer alır ve tek tırnak içine yaılır.

            // String veri tipi
            string metin = "string veri tipinde \n \t tüm karakterleri kullanabiliriz"; // \n metinde kendinden sonraki alanın bir alt satırdan devam etmesini, \t ise klavyeden tab tuşuna basmış gibi metni ileri iter.

            // Boolean veri tipi
            // Geriye true veya false dönen veri tipidir , 1 bytelık yer kaplar.
            bool islemSonuc = true;


            const int plaka3 = 18;  // Sabitler
            // consolewriteline hızlıca yazmak için cw + tab + tab
            Console.WriteLine(metin);

            Console.Read();




        }
    }
}
