using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeConversions
{
    internal class Program
    {
        static int solveMeFirst(int a, int b)
        {
            int sum;
          
            sum = a + b;
                
            
          
            return sum;
        }
        static void Main(string[] args)
        {


            //Implicit Conversion (Bilinçsiz Dönüşüm)

            //byte a = 5;
            //sbyte b = 30;
            //short c = 10;

            //int d = a + b + c;
            //Console.WriteLine("d : " + d);


            //long h = d;
            //Console.WriteLine("h : " + h);

            //float i = h;
            //Console.WriteLine("i : " + i);

            //string e = "Oğuzhan";
            //char f = 'K';
            //object g = e + f + d;
            //Console.WriteLine("g : " + g);



            ////Explicit Conversion (Bilinçli Dönüşüm)

            //Console.WriteLine("***** Explicit Conversion ******");

            //int x = 4;
            //byte y = (byte)x;
            //Console.WriteLine("y: " + y);

            //int z = 100;
            //byte t = (byte)z;

            //Console.WriteLine("t : " + t);



            //// *** To String *** 

            //int xx = 6;
            //string yy = xx.ToString();

            //Console.WriteLine(yy);

            //string zz = 12.5f.ToString();
            //Console.WriteLine(zz);


            ////System.Convert

            //string s1 = "10",s2 = "20";

            //int sayi1, sayi2;

            //int toplam;

            //sayi1 = Convert.ToInt32(s1);
            //sayi2 = Convert.ToInt32(s1);

            //toplam = sayi1 + sayi2;

            //Console.WriteLine(toplam);


            //string ss = "10";
            //string ss2 = "10.5";

            //int rakam = int.Parse(ss);
            //double rakam1 = double.Parse(ss2);



            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());


            if ((val1 >= 1 && val1 <= 100) && (val2 >= 1 && val2 <= 100))
            {
                int sum = solveMeFirst(val1, val2);
                Console.WriteLine(sum);

            }
            else
            {
                int sum = solveMeFirst(val1, val2);
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
