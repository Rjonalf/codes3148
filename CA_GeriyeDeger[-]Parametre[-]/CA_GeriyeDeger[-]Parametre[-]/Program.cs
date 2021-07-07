using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Odevler
{
    class Program
    {
        static void Main(string[] args)
        {
            BenimAdımNe();
            BenimSoyadımNe();
            KaçYaşındayım();
            OturduğumYer();
            HangiKursaGidiyorum();
            KursumNerede();
            HangiGünlerEğitimVar();
            SaatAralığı();
            HocaKim();
            HocaDünNeİşledi();
            Console.ReadLine();

        }

        //Merhaba Fatih Hocam, buraya geriye değer döndürmeyen ve parametre almayan 10 metodu sıralıyorum.
        // voidlerde genelde PascalCase kullanılır, PascalCase kelime başlarındaki harflerin büyük harf olmasını gerektirir.

        //1
        static void BenimAdımNe()
        {
            Console.WriteLine("Adım: Yasin");
        }


        //2
        static void BenimSoyadımNe()
        {
            Console.WriteLine("Soyadım: Şafak");
        }

        //3
        static void KaçYaşındayım()
        {
            Console.WriteLine("Yaş: 34");
        }

        //4
        static void OturduğumYer()
        {
            Console.WriteLine("Adres: Bostancı");
        }

        //5
        static void HangiKursaGidiyorum()
        {
            Console.WriteLine("Kursum: Bilgeadam");
        }

        //6
        static void KursumNerede()
        {
            Console.WriteLine("Kursum Nerede: Kadıköy");
        }

        //7
        static void HangiGünlerEğitimVar()
        {
            Console.WriteLine("Eğitim Günleri: Pazartesi, Salı, Çarşamba, Perşembe");
        }

        //8
        static void SaatAralığı()
        {
            Console.WriteLine("Saat Aralığı: 10:00-14:15");
        }

        //9
        static void HocaKim()
        {
            Console.WriteLine("Hocam: Fatih Günalp");
        }

        //10
        static void HocaDünNeİşledi()
        {
            Console.WriteLine("Dün Ne İşlendi: At Yarışı ama 3. at dopingsizdi..:P");
        }

    }
}
