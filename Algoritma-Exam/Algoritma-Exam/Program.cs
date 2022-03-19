using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // **************** Exam 1:  ****************
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.


            Console.WriteLine("**************** Exam 1:  ****************");
            Console.Write("Lütfen girmek istediğiniz  sayı adedi giriniz: ");
            int n = int.Parse(Console.ReadLine());

            string total = "";


            for (int i = 0; i < n; i++)
            {
                Console.Write($"Lütfen {i + 1}. pozitif tam sayı giriniz. : ");
                int evenNumber = int.Parse(Console.ReadLine());

                if (evenNumber % 2 == 0)
                {
                    total += evenNumber.ToString() + " ";
                }
            }

            Console.WriteLine(total);

            Console.ReadLine();




            // **************** Exam 2:  ****************
            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.Write("Lütfen 1. Pozitif sayıyı giriniz : ");
            int n1 = int.Parse(Console.ReadLine());

            int[] numberArray = new int[n1];

            Console.Write("Lütfen 2. Pozitif sayıyı giriniz : ");
            int m = int.Parse(Console.ReadLine());



            for (int i = 0; i < n1; i++)
            {
                Console.Write($"Lütfen {i + 1}. pozitif tam sayı giriniz. : ");
                numberArray[i] = int.Parse(Console.ReadLine());

            }

            foreach (int i in numberArray)
            {
                if (m == i)
                {
                    Console.WriteLine(i);
                }
                else if (m % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();



            // **************** Exam 3:  ****************
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.


            Console.Write("Lütfen  Pozitif sayı giriniz : ");
            int n2 = int.Parse(Console.ReadLine());

            string[] wordArray = new string[n];

            for (int i = 0; i < n2; i++)
            {
                Console.Write($"Lütfen {i + 1}. Kelimeyi giriniz. : ");
                wordArray[i] = Console.ReadLine();
            }


            for (int i = wordArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(wordArray[i]);
            }

            // **************** Exam 4:  ****************

            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Lütfen bir cümle giriniz");
            string result = Console.ReadLine();

            string[] words;

            words = result.Split(' ');

            Console.WriteLine("cümlede {0} kelime var", words.Length);
            Console.WriteLine("cümlede {0} tane harf var", result.Length);





            Console.ReadLine();



        }
    }
}
