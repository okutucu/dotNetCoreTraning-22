using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Kavramı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan1 = new Calisan();

            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 23415634;
            calisan1.Departman = "İnsan Kaynakları";

            Calisan calisan2 = new Calisan();

            calisan2.Ad = "Arda";
            calisan2.Soyad = "Deniz";
            calisan2.No = 25645622;
            calisan2.Departman = "Satın ALma";

            calisan1.CalisanBilgileri();
            calisan2.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : {0}",Ad);
            Console.WriteLine("Çalışan Soyadı : {0}",Soyad);
            Console.WriteLine("Çalışan No : {0}",No);
            Console.WriteLine("Çalışan Departman : {0}", Departman);
        }
    }
}
