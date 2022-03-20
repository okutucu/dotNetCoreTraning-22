using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Kalitim
{
    public class Bitkiler:Canlilar
    {

        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler Fotosentez yapar.");
        }

        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki();
            Console.WriteLine("Bitkiker güneşe tepki verir.");
        }
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
          
        }
        public void TohumlaÇoğalma()
        {
            Console.WriteLine("Tohumlu bitkiler, tohumla çoğalır");
        }
    }
    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void SporlaÇoğalma()
        {
            Console.WriteLine("Tohumsuz bitkiler, sporla çoğalır");
        }
    }
}
