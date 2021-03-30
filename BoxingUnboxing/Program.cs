using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            Object obj = x; // boxing
            int y = (int)obj; // unboxing
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
