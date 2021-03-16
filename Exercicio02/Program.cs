using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            while (numero > 0)
            {
                Console.WriteLine(Math.Sqrt(numero).ToString("F3"));
                Console.Write("Digite outro número: ");
                numero = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Número Negativo!");

        }
    }
}
