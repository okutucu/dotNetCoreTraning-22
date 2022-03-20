using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_1
{
    public class Kisi
    {

        private string _name;
        private string _surname;
        private string _telNo;
        public List<Kisi> kisilerListesi = new List<Kisi>();

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string TelNo
        {
            get { return _telNo; }
            set { _telNo = value; }
        }

        

        public Kisi(string name, string surname, string telNo)
        {
            Name = name;
            Surname = surname;
            TelNo = telNo;
        }

        public Kisi()
        {

        }

        public void KisiGetir()
        {
            Console.WriteLine("Kişinin İsmi : {0}",Name);
            Console.WriteLine("Kişinin Soyismi : {0}",Surname);
            Console.WriteLine("Kişinin Tel No : {0}",TelNo);
        }

        
        public void KisileriGetir()
        {
            kisilerListesi.Add(new Kisi("Oğuzhan","Kutucu","05456667788"));
            kisilerListesi.Add(new Kisi("Kaan","Kutucu","123456789"));
            kisilerListesi.Add(new Kisi("Taha","Tuner","0555332211"));
            kisilerListesi.Add(new Kisi("Tuğra","Efe","1900663334"));
            kisilerListesi.Add(new Kisi("Serhan","Kılıç","08509876655"));
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Surname}, {this.TelNo} ";
        }



    }
}
