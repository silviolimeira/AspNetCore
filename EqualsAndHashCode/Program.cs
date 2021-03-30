using System;
using EqualsAndHashCode.Entities;

namespace EqualsAndHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            //string a = "Maria";
            //string b = "Alex";
            //Console.WriteLine(a.Equals(b));
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b); // Compara referencia de ponteiro de memoria

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
