using System;
using ExtensionMethod.Extensions;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 03, 25, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));

        }
    }
}
