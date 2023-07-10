using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematikOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("Matematik oyununa hoşgeldinzi");
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine();

            int soru = 1;
            string cevap;

            if (soru == 1) 
            {
                Console.WriteLine("30 x 4 + (5-4) = ?");
                Console.WriteLine();
                Console.WriteLine("A-) 19");
                Console.WriteLine("B-) 131");
                Console.WriteLine("C-) 141");
                Console.WriteLine("D-) 121");
                Console.WriteLine();
                Console.Write("Cevabınız : ");
                cevap = Console.ReadLine();

                if (cevap == "d" || cevap == "D")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış, toplam puanınız : 0 ");
                }
            }

            if (soru == 2)
            {
                Console.WriteLine();
                Console.WriteLine("1903 + 1903 - 2023 : ");
                Console.WriteLine();
                Console.WriteLine("A-) 1783");
                Console.WriteLine("B-) 1873");
                Console.WriteLine("C-) 1683 ");
                Console.WriteLine("D-) 1687 ");
                Console.WriteLine();
                Console.Write("Cevabınız : ");
                cevap = Console.ReadLine();

                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("Cevabınız doğru");
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış, toplam puanınız : 10 ");
                }
            }

            if (soru ==3)
            {
                Console.WriteLine();
                Console.WriteLine("37 + 23 + 41 + 133 - 159  : ");
                Console.WriteLine();
                Console.WriteLine("A-) 75");
                Console.WriteLine("B-) 85");
                Console.WriteLine("C-) 57 ");
                Console.WriteLine("D-) 87 ");
                Console.WriteLine();
                Console.Write("Cevabınız : ");
                cevap = Console.ReadLine();

                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("Cevabınız doğru");
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış, toplam puanınız : 20 ");
                }
            }

            if (soru == 3)
            {
                Console.WriteLine();
                Console.WriteLine("1903 - 1902 + 13  : ");
                Console.WriteLine();
                Console.WriteLine("A-) 14");
                Console.WriteLine("B-) 8");
                Console.WriteLine("C-) 9 ");
                Console.WriteLine("D-) 13 ");
                Console.WriteLine();
                Console.Write("Cevabınız : ");
                cevap = Console.ReadLine();

                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("Cevabınız doğru");
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış, toplam puanınız : 30 ");
                }
            }

            if (soru == 4)
            {
                Console.WriteLine();
                Console.WriteLine("1+1-2+5  : ");
                Console.WriteLine();
                Console.WriteLine("A-) 5");
                Console.WriteLine("B-) 6");
                Console.WriteLine("C-) 7 ");
                Console.WriteLine("D-) 8 ");
                Console.WriteLine();
                Console.Write("Cevabınız : ");
                cevap = Console.ReadLine();

                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("Cevabınız doğru tebrikler 50 puan ile yarışmayı bitirdiniz...");
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış, toplam puanınız : 40 ");
                }
            }








            Console.Read();
        }
    }
}
