using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine(toplam/sayi);

            char character = 'a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;
            }
            string[] arabalar = { "BMW", "FORD", "TOYOTA", "NİSSAN" };
             
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }

        }


        
    }
}
