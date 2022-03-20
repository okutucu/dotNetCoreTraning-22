using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurucu_Fonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Ayşe","Kara", 23415634, "İnsan Kaynakları");

            //calisan1.Ad = "Ayşe";
            //calisan1.Soyad = "Kara";
            //calisan1.No = 23415634;
            //calisan1.Departman = "İnsan Kaynakları";

            Calisan calisan2 = new Calisan();

            calisan2.Ad = "Arda";
            calisan2.Soyad = "Deniz";
            calisan2.No = 25645622;
            calisan2.Departman = "Satın ALma";

            Calisan calisan3 = new Calisan("Zikriye","Ürkmez");
            calisan3.Departman = "IT";
            calisan3.No = 23323212;

            calisan1.CalisanBilgileri();
            calisan2.CalisanBilgileri();
            calisan3.CalisanBilgileri(); 

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public Calisan(string _ad, string _soyad,int _no,string _departman)
        {
            this.Ad = _ad;
            this.Soyad = _soyad;
            this.No = _no;
            this.Departman = _departman;
        }

        public Calisan(string _ad, string _soyad)
        {
            this.Ad = _ad;
            this.Soyad = _soyad;
          
        }

        public Calisan()
        {

        }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : {0}", Ad);
            Console.WriteLine("Çalışan Soyadı : {0}", Soyad);
            Console.WriteLine("Çalışan No : {0}", No);
            Console.WriteLine("Çalışan Departman : {0}", Departman);
        }
    }
}
