using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine("Length: " + mat.Length);
            Console.WriteLine("Rank (linhas): " + mat.Rank);
            Console.WriteLine("GetLength(0) linhas: " + mat.GetLength(0));
            Console.WriteLine("GetLength(0) colunas: " + mat.GetLength(1));
        }
    }
}
