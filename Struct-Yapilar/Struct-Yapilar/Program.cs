using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Yapilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diktortgen diktortgen = new Diktortgen();
            diktortgen.kisaKenar = 3;
            diktortgen.uzunKenar = 4;

            Console.WriteLine(diktortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct;

            dikdortgen_Struct.kisaKenar = 3;
            dikdortgen_Struct.uzunKenar = 4;

            Console.WriteLine(dikdortgen_Struct.AlanHesapla());


        }


    }
    class Diktortgen
    {
        public int kisaKenar;
        public int uzunKenar;

        public Diktortgen()
        {
            kisaKenar = 3;
            uzunKenar = 4;
        }

        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }

    }

    struct Dikdortgen_Struct
    {
        public int kisaKenar;
        public int uzunKenar;

        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }
}
