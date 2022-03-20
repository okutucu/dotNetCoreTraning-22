using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();

            tohumluBitki.Beslenme();
            tohumluBitki.Solunum();
            tohumluBitki.Bosaltim();
            tohumluBitki.Fotosentez();
            tohumluBitki.TohumlaÇoğalma();

            Kuslar marti = new Kuslar();

            marti.Solunum();
            marti.Beslenme();
            marti.Bosaltim();
            marti.Adaptasyon();
            marti.Ucmak();
        }
    }
}
