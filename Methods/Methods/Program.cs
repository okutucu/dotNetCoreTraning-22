using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 2;
            int b =3;

            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(sonuc.ToString());
            ornek.ArttırVeTopla(a, b);


        }

        static int Topla(int deger1,int deger2)
        {
            return deger1 + deger2;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArttırVeTopla(int deger1,int deger2)
        {
            deger1 ++;
            deger2 ++;

            return deger1 + deger2;

        }
    }
}
