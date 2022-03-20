using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Kalitim
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar Beslenir.");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlılar Solunum Yapar.");
        }

        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar Boşaltım Yapar.");
        }
    }
}
