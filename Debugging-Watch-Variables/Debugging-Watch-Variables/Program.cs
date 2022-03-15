using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging_Watch_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try // Hataya neden olabilecek kodu yazıyoruz ..
            {
                Console.WriteLine("Bir Sayı giriniz : ");
                int sayi = int.Parse(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata : " + ex.Message.ToString());
            }
            //finally
            //{
            //    Console.Write("İşlem tamamlandı..");
            //}

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya çok büyük bir değer girdiniz..");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı");
            }


        }
    }
}
