using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Yarışması_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soru = 1;
            string cevap;
            Console.WriteLine("********* BİLGİ YARIŞMASINA HOŞ GELDİNİZ *********");
            Console.WriteLine();
            Console.WriteLine("1.SORU = Türkiye'nin Başkenti neresidir ? ");
            Console.WriteLine();
            Console.WriteLine("A-) İstanbul");
            Console.WriteLine("B-) Ankara");
            Console.WriteLine("C-) Adana");
            Console.WriteLine("D-) İzmir");
            Console.Write("CEVAP:");
            cevap = Console.ReadLine();
            if (cevap == "B" || cevap == "b")
            {
                soru = soru + 1;
            }
            else
            {
                Console.WriteLine("********** YANLIŞ CEVAP **********");
            }
            if (soru == 2)
            {
                Console.WriteLine();
                Console.WriteLine("2.SORU = Cumhuriyet hangi tarihte ilan edildi ? ");
                Console.WriteLine();
                Console.WriteLine("A-) 1920");
                Console.WriteLine("B-) 1919");
                Console.WriteLine("C-) 1923");
                Console.WriteLine("D-) 1915");
                Console.Write("CEVAP:");
                cevap = Console.ReadLine();
                if (cevap == "C" || cevap == "c")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("********** YANLIŞ CEVAP **********");
                }
                if (soru == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("3.SORU = Hücreye enerji veren organelimiz hangisidir ? ");
                    Console.WriteLine();
                    Console.WriteLine("A-) Mitokondri");
                    Console.WriteLine("B-) Ribozom");
                    Console.WriteLine("C-) Endoplazmik retikulum");
                    Console.WriteLine("D-) Koful");
                    Console.Write("CEVAP:");
                    cevap = Console.ReadLine();
                    if (cevap == "A" || cevap == "a")
                    {
                        soru = soru + 1;
                    }
                    else
                    {
                        Console.WriteLine("********** YANLIŞ CEVAP **********");
                    }
                    Console.WriteLine();
                    Console.WriteLine("TEBRİKLER PUANINIZ 30 - KAZANDINIZ ");
                    Console.Read();
                }

            }

        }
    }
}
