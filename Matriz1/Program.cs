using System;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordemn = int.Parse(Console.ReadLine());
            
            int[,] mat = new int[ordemn, ordemn];
            for (int l = 0; l < ordemn; l++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int c = 0; c < ordemn; c++)
                {
                    mat[l, c] = int.Parse(valores[c]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int l = 0; l < ordemn; l++)
            {
                Console.Write(mat[l, l] + " ");
            }
            Console.Write("Negative numbers = ");
            int negativos = 0;
            for (int l = 0; l < ordemn; l++)
            {
                for (int c = 0; c < ordemn; c++)
                {
                    if (mat[l, c] < 0) negativos++;
                }
            }
            Console.WriteLine(negativos);
        }
    }
}
