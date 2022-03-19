﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_and_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);


            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(2));
            Console.WriteLine(DateTime.Now.AddSeconds(20));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));


            // DateTime Format

            Console.WriteLine(DateTime.Now.ToString("dd")); // 24
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); // 04
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // April

            Console.WriteLine(DateTime.Now.ToString("yy")); // 22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2022


            // Math Kütüphanesi

            Console.WriteLine(Math.Abs(-25)); // 25
            Console.WriteLine(Math.Sin(10)); 
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); // Büyüğe yuvarlar
            Console.WriteLine(Math.Round(22.3));   // Hangisine daha yakınsa
            Console.WriteLine(Math.Floor(22.7));   // Küçüğe yuvarlar


            Console.WriteLine(Math.Pow(3,4)); // 3^4 verir. => 81
            Console.WriteLine(Math.Sqrt(9)); // Karakök alır => 3
            Console.WriteLine(Math.Log(9)); //  9un 3 tabanındaki logoritmik karşılığını verir.
            Console.WriteLine(Math.Exp(3)); //e üzeri 3 ü verir.
            Console.WriteLine(Math.Log10(10)); //10 sayısının logaritma 10 tabanındaki karşılığı





        }
    }
}
