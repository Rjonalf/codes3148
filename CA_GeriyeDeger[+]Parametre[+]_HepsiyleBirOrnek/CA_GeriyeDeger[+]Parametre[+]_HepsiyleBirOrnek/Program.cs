using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_GeriyeDeger___Parametre____HepsiyleBirOrnek
{
    class Program
    {
        static void DikdortgenAlan1()
        {
            Console.Write("Kısa Kenarı Giriniz: ");
            int kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun Kenarı Giriniz: ");
            int uzunKenar = Convert.ToInt32(Console.ReadLine());
            int alan = kisaKenar * uzunKenar;
            Console.WriteLine("Dikdörtgeninizin Alanı: {0}", alan);
        }

        static void DikdörtgenAlan2(int kisa, int uzun)
        {
            int alan = kisa * uzun;
            Console.WriteLine("Dikdörtgenin Alanı: {0}", alan);
        }

        static int DikdörtgenAlan3()
        {
            Console.WriteLine("Kısa Kenarı Giriniz: ");
            int kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun Kenarı Giriniz: ");
            int uzunKenar = Convert.ToInt32(Console.ReadLine());
            int alan = kisaKenar * uzunKenar;
            Console.WriteLine("Dikdörtgeninizin Alanı: {0}", alan);
            return alan;
        }

        static int DikdörtgenAlan4(int kisa, int uzun)
        {
            int alan = kisa * uzun;
            Console.WriteLine("Dikdörtgenin Alanı: {0}",alan);
            return alan;
        }

        static void Main(string[] args)
        {

            #region 1- Geriye Değer Döndürmeyen ve Parametre Almayan Metot
            //DikdortgenAlan1(); 
            #endregion


            #region 2- Geriye Değer Döndürmeyen Parametre Alan Metot
            //Console.Write("Kısa Kenarı Giriniz: ");
            //int kisaKenar = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Uzun Kenarı Giriniz: ");
            //int uzunKenar = Convert.ToInt32(Console.ReadLine());
            //DikdörtgenAlan2(kisaKenar, uzunKenar); 
            #endregion

            #region 3- Geriye Değer Döndüren Parametre Almayan Metot
            //DikdörtgenAlan3(); 
            #endregion

            #region 4- Geriye Değer Döndüren Parametre Alan Metot
            //Console.WriteLine("Kısa Kenarı Giriniz: ");
            //int kisaKenar = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Uzun Kenarı Giriniz: ");
            //int uzunKenar = Convert.ToInt32(Console.ReadLine());
            //DikdörtgenAlan4(kisaKenar, uzunKenar); 
            #endregion


            Console.ReadLine();

        }
    }
}
