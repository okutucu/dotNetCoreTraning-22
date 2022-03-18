using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] renkler = new string[5];

            //string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            //int[] dizi;
            //dizi = new int[5];

            //renkler[0] = "Mavi";
            //dizi[3] = 10;
            //Console.WriteLine(hayvanlar[1]);
            //Console.WriteLine(dizi[3]);
            //Console.WriteLine(renkler[0]);

            //Console.WriteLine("Lütfen dizinin eleman sayısını giriniz :");
            //int diziUzunlugu = int.Parse(Console.ReadLine());
            //int[] sayiDizisi = new int[diziUzunlugu];

            //for (int i = 0; i < diziUzunlugu; i++)
            //{
            //    Console.WriteLine("Lütfen {0}. sayısı giriniz : ", i+1);
            //    sayiDizisi[i] = int.Parse(Console.ReadLine());
            //}

            //int toplam = 0;
            //foreach (var item in sayiDizisi)
            //{
            //    toplam += item;
            //}

            //Console.WriteLine("Ortlama : " + toplam/diziUzunlugu);


            int[] sayilar ={ -4, -3, -9, 0, 4, 1 };

            int arrayLength = sayilar.Length;
            decimal countP = 0;
            decimal countN = 0;
            decimal countZ = 0;

            foreach (int i in sayilar)
            {
                if (i==0)
                {
                    countZ++;
                }
                else if (i<0)
                {
                    countN++;
                }
                else
                {
                    countP++;
                }
            }

            Console.WriteLine(Math.Round((countP/arrayLength),6));
            Console.WriteLine(Math.Round((countN/arrayLength),6));
            Console.WriteLine(Math.Round((countZ/arrayLength),6));
           



            Console.ReadLine();
        }
    }
}
