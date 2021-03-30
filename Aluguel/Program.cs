using System;

namespace Aluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int alugados = int.Parse(Console.ReadLine());

            Bathroom[] bathrooms = new Bathroom[10];

            for (int i = 0; i < alugados; i++)
            {
                Console.WriteLine("Rent #{0}:", i+1);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                bathrooms[room] = new Bathroom { Name = name, Email = email };
            }

            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (bathrooms[i] != null)
                {
                    Console.WriteLine(i + ": " + bathrooms[i].Name
                        + ", " + bathrooms[i].Email);
                }
            }

        }
    }
}
