using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_1
{
    public  class KisiYonetimi : Kisi
    {
        public void KisiEkle()
        {
            Console.Write("İsminiz : ");
            string name = Console.ReadLine();

            Console.Write("Soyisminiz : ");
            string surname = Console.ReadLine();

            Console.Write("Tel No : ");
            string no = Console.ReadLine();

            Kisi kisi = new Kisi(name, surname, no);
            kisilerListesi.Add(kisi);
           
            Console.WriteLine("Hoşgeldiniz Sayın {0} {1}", kisi.Name.ToUpper(),kisi.Surname.ToUpper());
        }
        public void NumaraSil()
        {
            string cikis = "1";
            string secim1 = " ";
            do
            {
                KisileriGetir();
                Console.Write("Lütfen numarasını silmek istediğiniz kişinin Adını ya da Soyadını giriniz : ");
                string result = Console.ReadLine();

                bool kayitVarMi = false;

                for (int i = 0; i < kisilerListesi.Count; i++)
                {
                    if (result == kisilerListesi[i].Name || result == kisilerListesi[i].Surname)
                    {
                        Console.WriteLine("Kullanıcı {0} silmek istediğinize eminmisiniz y/n", kisilerListesi[i].Name);
                        var yN = Console.ReadLine();
                        kayitVarMi = true;

                        if (yN == "y")
                        {
                            kisilerListesi.Remove(kisilerListesi[i]);
                            Console.WriteLine("Başarı ile silinmiştir");
                            secim1 = "1";
                        }
                    }

                }
                if (!kayitVarMi)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine(
                            " Silmeyi sonlandırmak için : (1)" +
                            "\n Yeniden denemek için      : (2)"

                        );
                    Console.Write("Seçiminiz : ");
                    secim1 = Console.ReadLine();

                    if (secim1 == "1")
                    {
                        secim1 = cikis;
                    }
                    else if (secim1 == "2")
                    {
                        Console.WriteLine("Yeniden Deneyiniz..");
                    }

                }

            } while (cikis != secim1);

            Console.WriteLine("Programdan Çıkıldı !!");

        }

        public void NumaraGuncelle()
        {
            string cikis = "1";
            string secim1 = " ";

            do
            {
                KisileriGetir();
                Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin Adını ya da Soyadını giriniz : ");
                string result = Console.ReadLine();

                bool kayitVarMi = false;

                for (int i = 0; i < kisilerListesi.Count; i++)
                {
                    if (result == kisilerListesi[i].Name || result == kisilerListesi[i].Surname)
                    {
                        Console.WriteLine("Kullanıcı {0} güncellemek istediğinize eminmisiniz y/n", kisilerListesi[i].Name);
                        var yN = Console.ReadLine();
                        kayitVarMi = true;

                        if (yN == "y")
                        {
                            Console.Write("Yeni Telefon No Giriniz: ");
                            string newTelNo = Console.ReadLine();
                            kisilerListesi[i].TelNo = newTelNo;
                            Console.WriteLine("Başarı ile güncellendi");
                            secim1 = "1";
                        }
                    }


                }

                if (!kayitVarMi)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine(
                            " Silmeyi sonlandırmak için : (1)" +
                            "\n Yeniden denemek için      : (2)"

                        );
                    Console.Write("Seçiminiz : ");
                    secim1 = Console.ReadLine();

                    if (secim1 == "1")
                    {
                        secim1 = cikis;
                    }
                    else if (secim1 == "2")
                    {
                        Console.WriteLine("Yeniden Deneyiniz..");
                    }

                }

            } while (cikis != secim1);

            Console.WriteLine("Programdan Çıkıldı !!");

        }


        public void KisileriListele()
        {
            KisileriGetir();
            foreach (var item in kisilerListesi)
            {
                Console.WriteLine($"İsim : {item.Name}");
                Console.WriteLine($"Soyisim : {item.Surname}");
                Console.WriteLine($"İsim : {item.TelNo}");
                Console.WriteLine("\n-");
            }
        }
    }
}
