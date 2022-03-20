using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyon_Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            int[] numberArray = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Lütfen {i +1 }. Sayıyı giriniz :");
                int number = int.Parse(Console.ReadLine());

                numberArray[i] = number;
            }


          

            Array.Sort(numberArray);

            int[] enKucuk = new int[3];
            int[] enBuyuk = new int[3];

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (i == 3)
                {
                    break;
                }
                else
                {
                      enKucuk[i] = numberArray[i];
                }
            }

            Array.Reverse(numberArray);

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (i == 3)
                {
                    break;
                }
                else
                {
                    enBuyuk[i] = numberArray[i];
                }
            }

            int enKucukToplam = 0;
            int enBuyukToplam = 0;


            foreach (var item in enKucuk)
            {
                enKucukToplam += item;

            }
            foreach (var item in enBuyuk)
            {
                enBuyukToplam += item;
            }

            Console.WriteLine($"En Küçük Sayıların Ortalaması : {enKucukToplam / 3}");
            Console.WriteLine($"En Büyük Sayıların Ortalaması : {enBuyukToplam / 3}");


            Console.WriteLine($"2 Ortalamanın Toplamı : {(enKucukToplam / 3) +(enBuyukToplam / 3) }");


            Console.ReadLine();
        }
    }
}
