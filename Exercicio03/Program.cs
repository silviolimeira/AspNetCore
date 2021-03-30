using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números você vai digitar?");
            int quantidade = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i < quantidade; )
            {
                Console.Write($"Valor #{++i}: ");
                total += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Soma: {0}", total);

        }
    }
}
