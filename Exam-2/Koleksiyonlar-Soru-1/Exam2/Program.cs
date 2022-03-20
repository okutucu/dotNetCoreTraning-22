using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exam2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            // Negatif ve numeric olmayan girişleri engelleyin.
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            
            ArrayList asal = new ArrayList();
            ArrayList asalDegil = new ArrayList();
            ArrayList numbers = new ArrayList();

            try
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write($"Lütfen {i+1}. Adet Pozitif ve Nümeric  Sayı giriniz.. : ");
                    int number = int.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        Console.WriteLine("Lütfen Pozitif ve Nümeri Tam sayı giriniz.");
                        break;

                    }
                    else
                    {
                        int bayrak = 0;
                        for (int j = 2; j < number; j++)
                        {
                            if (number % j == 0)
                            {
                                bayrak++;
                            }
                        }

                        if (bayrak ==0)
                        {
                            asal.Add(number);
                        }
                        else
                        {
                            asalDegil.Add(number);
                        }
                    }

                    numbers.Add(number);


                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Lütfen Pozitif ve Nümeri Tam sayı giriniz.");
            }


            asal.Sort();
            asal.Reverse();
            asalDegil.Sort();
            asalDegil.Reverse();

            int asalToplam = 0;
            int asalOlmayanToplam = 0;

            foreach (int item in asal)
            {
                Console.WriteLine(item);
                asalToplam += item;
            }

            foreach (int item in asalDegil)
            {
                Console.WriteLine(item);
                asalOlmayanToplam +=  item;
            }

            

            Console.WriteLine($"Asal Sayıların Eleman Sayısı : {asalToplam} ve Ortalaması {asalToplam / asal.Count}");
            Console.WriteLine($"Asal Olmayan Sayıların Eleman Sayısı : {asalOlmayanToplam} ve Ortalaması {asalOlmayanToplam / asal.Count}");





            Console.ReadLine();
        }
    }
}
