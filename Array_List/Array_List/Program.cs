using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //System.Collections namespaces


            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //AddRange
            Console.WriteLine("***** ADD RANGE *****");
            //string[] renkler = { "Mavi", "Yeşil", "Kırmızı" };
            List<int> sayilar = new List<int>(){ 1, 8, 3,7,9,92,5 };
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("*****SORT *****");
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Binary Search 
            Console.WriteLine("***** Binary Search *****");
            Console.WriteLine(liste.BinarySearch(9));

            // Reverse 
            liste.Reverse();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
