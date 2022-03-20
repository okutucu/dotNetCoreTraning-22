using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Kalitim
{
    public class Hayvanlar:Canlilar
    {

        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar Adaptasyon kurabilir");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temesa tepki verir.");
        }
    }
    public class Surungenler:Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
          
        }
        public void SurunerekHareketEderler()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }

    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuslar uçarak hareket eder.");
        }
    }
}
