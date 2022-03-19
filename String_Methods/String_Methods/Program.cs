using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Hello World, I'm Oğuzhan";
            string degisken2 = "World";

            Console.WriteLine(degisken.Length);


            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());


            // Contact  --> Verilen Stringi birleştirir.

            Console.WriteLine(String.Concat(degisken," Kutucu"));


            // Compare  --> true = büyük küçük harf duyarsız.. false= duyarlı.
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            // CompareTO --> Karşılaştırma --- eşit ise 0 döndürür. büyükse 1 - küçükse -1
            Console.WriteLine(degisken.CompareTo(degisken2));


            // Contains --> içinde var mı ??

            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Kutucu")); // Kutucu ile bitiyor mu ?
            Console.WriteLine(degisken.StartsWith("Kutucu")); // Kutucu ile başlıyor  mu ?


            // IndexOF --> O'yu bulursa ilk indexini döner -- Bulamazsa -1 döner..
            Console.WriteLine(degisken.IndexOf("Oğuzhan"));
            // LastIndexOF --> valuenin son indexini getirir.
            Console.WriteLine(degisken.LastIndexOf("n"));


            // Insert --> verilen indexten başlayarak yolladığımız value ekler
            Console.WriteLine(degisken.Insert(0,"Merhaba!"));

            // Padleft , PadRight; --> Padleft degisken 30 karakter kadar boşkuk ekler
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));


            // Remove  --> 10. indexten başlayıp sonrasını siler.
            Console.WriteLine(degisken.Remove(10));

            // Replace
            Console.WriteLine(degisken.Replace("Merhaba", "What's Up !"));
            Console.WriteLine(degisken.Replace(" ", "-"));

            //Split
            Console.WriteLine(degisken.Split(' ')[0]);

            //Substring --> belirttiğimiz indexten sonraki değerleri getirir.
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

         
            
        }
    }
}
