using System;
using System.Globalization;

namespace DateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt);
            //Console.WriteLine(dt.Ticks);
            //Console.WriteLine();
            //Console.WriteLine("=====================");
            //Console.WriteLine();

            //DateTime d1 = new DateTime(2018, 11, 25);
            //DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            //DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            //DateTime d4 = DateTime.Now;
            //DateTime d5 = DateTime.Today;
            //DateTime d6 = DateTime.UtcNow;

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);

            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine();
            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d3 = DateTime.Parse("15/08/2000 20:55:45");
            DateTime d4 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d5 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine();
            Console.WriteLine(d4);
            Console.WriteLine(d5);

        }
    }
}
