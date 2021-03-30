using System;
using Vector1;
using System.Globalization;

namespace Vetor1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                decimal preco = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto { Nome = nome, Preco = preco };

            }

            decimal sum = 0.0M;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Preco;
            }

            decimal avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
