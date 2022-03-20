using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SecimArayuzu.SecimArayuzunuGetir();
            Console.Write("Yapmak İstediğiniz Seçim : ");

            try
            {
                int result = int.Parse(Console.ReadLine());
                IslemSecim islem = new IslemSecim();
                islem.IslemOgren(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen Değer Aralığında Bir Sayı Giriniz.");
            }

           

            



            
          

            Console.ReadLine();

        }
    }
}
