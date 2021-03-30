using System;

namespace Matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dim = Console.ReadLine().Split(' ');
            int lins = int.Parse(dim[0]);
            int cols = int.Parse(dim[1]);

            int[,] mat = new int[lins, cols];

            for (int l = 0; l < lins; l++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int c = 0; c < cols; c++)
                {
                    mat[l, c] = int.Parse(values[c]);
                }
            }

            int elem = int.Parse(Console.ReadLine());

            for (int l = 0; l < lins; l++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (mat[l,c] == elem)
                    {
                        Console.WriteLine("Position: {0},{1}", l, c);
                        if (c - 1 >= 0) Console.WriteLine("Left: " + mat[l, c - 1]);
                        if (c + 1 < cols) Console.WriteLine("Right: " + mat[l, c + 1]);
                        if (l - 1 >= 0) Console.WriteLine("Up: " + mat[l - 1, c]);
                        if (l + 1 < lins) Console.WriteLine("Down: " + mat[l + 1, c]);
                    }
                }
            }
        }
    }
}
