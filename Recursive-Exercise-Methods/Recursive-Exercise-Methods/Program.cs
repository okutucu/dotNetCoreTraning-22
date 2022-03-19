using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercise_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Rekürsif -- Öz yenilemeli

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }

            Console.WriteLine(result);

            Islemler istance = new Islemler();

            Console.WriteLine(istance.Expo(3, 4));

            // Extension Methotlar

            string ifade = "Zikriye Ürkemez Cengiz";


            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            Console.WriteLine(ifade.MakeUpperCase());


            int[] dizi = {9, 3, 6, 2, 1, 5, 0};
            dizi.SortArray();

            dizi.EkranaYazdir();


        }
    }

    public class Islemler
    {
        public int Expo(int sayi,int us)
        {
            if (us<2)
            {
                return sayi;
            }
            return Expo(sayi, us - 1) * sayi;
        }

        // Expo(3,4);
        // Expo(3,3) *3;
        // Expo(3,2) *3 * 3;
        // Expo(3,1) *3 * 3 * 3;
        // 3*3*3*3 = 3^4;


    }

    public static class Extension
    {
        // Extension Method'a This keywordunu eklememiz lazım
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(' ');
            return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

    }
}
