using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ılkProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bu bizim ilk program kodumuz. "); //Console.Write ile ekrana yazı yazdırılıyor.
            // Program.Main();
            Console.Read();

            // Eğer yukarda using systemi iptal edersek System.Console.Read(); şeklinde kullanabiliriz.

            Console.Write("Bu bizim ikinci program kodumuz. ");

            Console.WriteLine("Console writeline metodu alt satırdan yazıyı devam ettirir ");
            Console.WriteLine("Console writeline metodu alt satırdan yazıyı devam ettirir ");
            Console.WriteLine("Console writeline metodu alt satırdan yazıyı devam ettirir ");

            Console.Read(); //console read metodu ekrandan 1 karakterlik veri okur.
        }
    }
}
