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
            Topla();
            Çıkar();
            Çarp();
            Böl();
            ToplaSonraÇıkar();
            ÇıkarSonraÇarp();
            BölSonraTopla();
            ModAl();
            ModAlSonraToplaSonraÇarp();
            ToplaSonraÇıkarSonraÇarpSonraBöl();
            Console.ReadLine();

        }

        static int Topla()
        {
            int number1=10, number2 = 5;
            int result = number1 + number2;
            Console.WriteLine("Toplama İşleminin Sonucu: {0}", result);
            return result;
        }

        static int Çıkar()
        {
            int number1 = 10, number2 = 8;
            int result2 = number1 - number2;
            Console.WriteLine("Çıkarma İşleminin Sonucu: {0}", result2);
            return result2;

        }

        static int Çarp()
        {
            int number1 = 10, number2 = 3;
            int result3 = number1 * number2;
            Console.WriteLine("Çarpma İşleminin Sonucu: {0}", result3);
            return result3;
        }

        static int Böl()
        {
            int number1 = 500, number2 = 2;
            int result4 = number1/number2;
            Console.WriteLine("Bölme İşleminin Sonucu: {0}", result4);
            return result4;
        }

        static int ToplaSonraÇıkar()
        {
            int number1 = 10, number2 = 5, number3 = 5;
            int result5 = (number1 + number2) - number3;
            Console.WriteLine("Toplayıp Çıkardıktan Sonra Sonuç: {0}", result5);
            return result5;
        }

        static int ÇıkarSonraÇarp()
        {
            int number1 = 8, number2 = 6, number3 = 7;
            int result6 = (number1 - number2) * number3;
            Console.WriteLine("Çıkarıp Çarptıktan Sonra Sonuç: {0}", result6);
            return result6;
        }

        static int BölSonraTopla()
        {
            int number1 = 6, number2 = 2, number3 = 7;
            int result7 = (number1 / number2) + number3;
            Console.WriteLine("Böldükten Sonra Toplama İşleminin Sonucu: {0}", result7);
            return result7;
        }

        static int ModAl()
        {
            int number1 = 10, number2 = 8;
            int result8 = number1 % number2;
            Console.WriteLine("Mod Alındıktan Sonra İşlemin Sonucu: {0}", result8)
            return result8;
        }

        static int ModAlSonraToplaSonraÇarp()
        {
            int number1 = 10, number2 = 8, number3 = 8, number4 = 5;
            int result9 = (((number1 % number2) + number3) * number4);
            Console.WriteLine("Mod Alınıp,Toplanıp, Çarpma İşleminin Sonucu: {0}", result9);
            return result9;
        }

        static int ToplaSonraÇıkarSonraÇarpSonraBöl()
        {
            int number1 = 10, number2 = 5, number3 = 5, number4 = 3, number5 = 2;
            int result10 = ((((number1 + number2) - number3) * number4) / number5);
            Console.WriteLine("Toplanıp Çıkarılıp Çarpılıp Bölündükten Sonraki İşlem Sonucu: {0}", result10);
            return result10;
        }
    }
}
