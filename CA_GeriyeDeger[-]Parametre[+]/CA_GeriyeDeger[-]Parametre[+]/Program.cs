using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_GeriyeDeger___Parametre___
{
    class Program
    {
        static void Main(string[] args)
        {
            Topla(20, 15);
            Çıkar(38, 2);
            Böl(28, 2);
            Çarp(133, 3);
            ModAl(20, 3);
            ToplaSonraÇıkar(30, 15, 5);
            ToplaSonraBöl(30, 15, 5);
            ÇıkarSonraÇarp(50, 10, 2);
            ModAlveÇarp(100, 9, 3);
            ToplaSonraÇarpSonraBölSonraTovbeEstagfurullah(1, 2, 3, 3);
            Console.ReadLine();

        }

        static void Topla(int sayi1, int sayi2)
        {

        Console.WriteLine("Toplama İşleminin Sonucu: {0}", sayi1+sayi2);

        }

        static void Çıkar(int sayi1, int sayi2)
        {
            Console.WriteLine("Çıkarma İşleminin Sonucu: {0}", sayi1-sayi2);

        }

        static void Böl(int sayi1, int sayi2)
        {
            Console.WriteLine("Bölme İşleminin Sonucu: {0}", sayi1 / sayi2);

        }

        static void Çarp(int sayi1, int sayi2)
        {
            Console.WriteLine("Çarpma İşleminin Sonucu: {0}", sayi1 * sayi2);

        }

        static void ModAl(int sayi1, int sayi2)
        {
            Console.WriteLine("Mod Alınan Sonuç: {0}", sayi1 % sayi2);

        }

        static void ToplaSonraÇıkar(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine("Toplanıp Çıkarılan Sonuç: {0}", (sayi1+sayi2) - sayi3);

        }

        static void ToplaSonraBöl(int sayi1, int sayi2,int sayi3)
        {
            Console.WriteLine("Toplanıp Bölünen Sonuç: {0}", (sayi1 + sayi2) / sayi3);

        }

        static void ÇıkarSonraÇarp(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine("Çıkarıldıktan sonra Çarpılan Sonuç: {0}", (sayi1 - sayi2) * sayi3);

        }

        static void ModAlveÇarp(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine("Mod Alınıp Çarpılan Sonuç: {0}", (sayi1 % sayi2) * sayi3);

        }

        static void ToplaSonraÇarpSonraBölSonraTovbeEstagfurullah(int sayi1, int sayi2, int sayi3, int sayi4)
        {
            Console.WriteLine("Evet Canım Sıkılıyor Ne Var?: {0}", ((((sayi1+sayi2) * sayi3) / sayi4)));

        }
    }
}
