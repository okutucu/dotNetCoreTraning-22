using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Elseif_Ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int time = DateTime.Now.Hour;

            if (time>=5 && time<11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time <=18)
            {
                Console.WriteLine("İyi Günler");
            }
            else
            {
                Console.WriteLine("İyi Geceler");
            }

            string sonuc = time <= 18 ? "İyi Günler" : "İyi Geceler";

            sonuc = time >= 66 && time <= 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";

            Console.WriteLine(sonuc);

        }
    }
}
