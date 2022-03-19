using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // T --> object türündedir. Hangi tipten oluşan bir nesne olduğunu belirtir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");


            // Count --- List eleman sayısı

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            // Foreach ve listforeach ile elemanlara erişim
            foreach (var item in sayiListesi)
            {
                Console.WriteLine(item);
            }
            foreach (var item in renkListesi)
            {
                Console.WriteLine(item);
            }


            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            // Listeden eleman çıkartmak

            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            // Liste içiresinde arama

            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde bulundu!");
            }

            // Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            // Diziyi Listeye çevirmek
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Liste temizleme
            hayvanListesi.Clear();


            //Liste içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();

            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı1.Isim = "Özcan";
            kullanıcı1.Soyisim = "Çalışkan";
            kullanıcı1.Yas = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);
        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;


        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
        
    }
}
