using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            

            Console.WriteLine("Lütfen bir cümle giriniz.");
            string cumle = Console.ReadLine();
            string newCumle = cumle.Replace(" ", "").ToLower();
            

            char[] charArray = newCumle.ToCharArray();
            string sesliHarf = "aeıioöuü";


            string[] sesliHarfArray = new string[0];

           
            foreach (var item in charArray)
            {
                if (sesliHarf.Contains(item))
                {
                    Array.Resize(ref sesliHarfArray, sesliHarfArray.Length + 1);
                    sesliHarfArray[sesliHarfArray.Length - 1] = item.ToString();
                }
            }

            foreach (var item in sesliHarfArray)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
