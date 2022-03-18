using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_Break_Contiune
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Lütfen bir sayı giriniz : ");
            //int sayac = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= sayac; i++)
            //{
            //    if (i%2 ==1)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int tekToplam = 0;
            //int ciftToplam = 0;

            //for (int i = 0; i <= 1000; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        tekToplam += i;

            //    }
            //    else
            //    {
            //        ciftToplam += i;
            //    }
            //}

            //Console.WriteLine("Tek Toplam : "  + tekToplam);
            //Console.WriteLine("Çift Toplam : "  + ciftToplam);


            //// Break - Contiune

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i==4)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            Console.Write("SAyı : ");
            int n = int.Parse(Console.ReadLine());

            string result = "";
            int x = n;
            for (int i = 0; i < n; i++)
            {
                
                x--;

                for (int j = 0; j < x; j++)
                {
                    Console.Write(" ");
                }

                result += "#";

                Console.WriteLine(result);

            }

            Console.ReadLine();



        }
    }
}
