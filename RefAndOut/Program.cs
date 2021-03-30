using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example use Ref
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            Console.WriteLine();

            // Example use Out
            a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);


        }
    }
}
