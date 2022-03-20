using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_1
{
    public  class IslemSecim : KisiYonetimi
    {

        public  int IslemOgren(int x)
        {

                switch (x)
                {
                    case 1:
                        //KisiYonetimi kisiYonetimi = new KisiYonetimi();
                        KisiEkle();
                        Console.WriteLine("İşleminiz Başarılı Bir Şekilde Gerçekleştirilmiştir.");

                        break;
                    case 2:
                        NumaraSil();
                        Console.WriteLine("İşleminiz Başarılı Bir Şekilde Gerçekleştirilmiştir.");
                    break;
                    case 3:
                        NumaraGuncelle();
                        Console.WriteLine("İşleminiz Başarılı Bir Şekilde Gerçekleştirilmiştir.");
                        break;
                    case 4:
                        KisileriListele();
                        break;
                    case 5:
                        
                        break;
                    default:
                        Console.WriteLine("Yanlış bir şeçim yapıldı.");
                        break;
                    
                }

            return x;
        }

    }
}
