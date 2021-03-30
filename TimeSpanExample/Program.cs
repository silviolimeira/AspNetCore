using System;

namespace TimeSpanExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //// exemplo 1
            //TimeSpan t1 = new TimeSpan(0, 1, 30);
            //Console.WriteLine(t1);
            //Console.WriteLine(t1.Ticks);

            ////exemplo 2
            //TimeSpan t1 = new TimeSpan();
            //TimeSpan t2 = new TimeSpan(900000000L);
            //TimeSpan t3 = new TimeSpan(2, 11, 21);
            //TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            //TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);

            // Exemplo 3
            //TimeSpan t1 = TimeSpan.FromDays(1.5);
            //TimeSpan t2 = TimeSpan.FromHours(1.5);

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);

            //// Exemplo 4
            //DateTime d1 = new DateTime(2000, 10, 15);
            //DateTime d2 = new DateTime(2000, 10, 18);
            //TimeSpan t = d2.Subtract(d1);

            //Console.WriteLine(t);

            //// Exemplo 5
            //TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            //Console.WriteLine(t);
            //Console.WriteLine("Days: " + t.Days);

            //// Exemplo 6
            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            //Console.WriteLine("d1: " + d1);
            //Console.WriteLine("d1 Kind: " + d1.Kind);
            //Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            //Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine("d2: " + d2);
            //Console.WriteLine("d2 Kind: " + d2.Kind);
            //Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            //Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine("d3: " + d3);
            //Console.WriteLine("d3 Kind: " + d3.Kind);
            //Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            //Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());

            // Example 7
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
