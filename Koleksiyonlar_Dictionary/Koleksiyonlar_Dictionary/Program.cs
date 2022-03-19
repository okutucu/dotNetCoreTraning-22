using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,String> kullancilar = new Dictionary<int,String>();

            kullancilar.Add(10,"Oğuzhan Kutucu");
            kullancilar.Add(12,"Kaan Kutucu");
            kullancilar.Add(18,"Serhan Kılıç");
            kullancilar.Add(20,"Taha Tuner");

            // Dizinin elemanlarına erişim...

            Console.WriteLine(kullancilar[12]); // ->> key

            foreach (var item in kullancilar)
            {
                Console.WriteLine(item);
            }

            //Count;

            Console.WriteLine(kullancilar.Count);

            //Contains
            Console.WriteLine(kullancilar.ContainsKey(12));
            Console.WriteLine(kullancilar.ContainsValue("Oğuzhan Kutucu"));

            //Remove
            kullancilar.Remove(12);
        }
    }
}
