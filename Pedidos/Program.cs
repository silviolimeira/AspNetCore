using Pedidos.Entities.Enums;
using System;
using Pedidos.Entities;
using System.Globalization;

namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client c1 = new Client(name, email, birthDate);

            Order o1 = new Order(DateTime.Now, status, c1);

            Console.Write("How many items to this order? ");
            int total = int.Parse(Console.ReadLine());

            for (int i = 1; i <= total; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Name: ");
                string productname = Console.ReadLine();
                Console.Write("Product price: ");
                double productprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product prod = new Product(productname, productprice);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem oi = new OrderItem(quantity, productprice, prod);
                
                o1.AddItem(oi);
            }

            Console.WriteLine(o1.ToString());

        }
    }
}
