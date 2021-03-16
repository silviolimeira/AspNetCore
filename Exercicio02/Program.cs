using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            while (numero > 0)
            {
                Console.WriteLine(Math.Sqrt(numero).ToString("F3"));
                Console.WriteLine("Digite outro número: ");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Número Negativo!");

        }
    }
}
