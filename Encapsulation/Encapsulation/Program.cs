using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Ogrenci ogrenci = new Ogrenci();

            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);

            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
            

        }
    }

    class Ogrenci
    {
        private string _isim;

        private string _soyisim;

        private int ogrenciNo;

        private int sinif;

        public string Isim
        {
            get { return _isim; }
            set { _isim = value; }
        }

        public string Soyisim { get => _soyisim; set => _soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        { 
            get => sinif;
            set 
            {
                if (value <1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
                
            }
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci()
        {

        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*********** ÖĞRENCİ BİLGİLERİ *******");
            Console.WriteLine("Öğrenci Adı : {0} ",this.Isim);
            Console.WriteLine("Öğrenci Soyadı : {0} ",this.Soyisim);
            Console.WriteLine("Öğrenci No : {0} ",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıf : {0} ",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
