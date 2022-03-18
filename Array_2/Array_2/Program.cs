using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }


            Array.Sort(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            Array.Clear(sayiDizisi, 2, 2);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }


            Array.Reverse(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            Array.Resize<int>(ref sayiDizisi, 9);
        }
    }
}
