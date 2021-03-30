using System;
using System.Collections.Generic;
using System.Globalization;
using ActionExample.Entities;

namespace ActionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // Example 1
            //list.ForEach(UpdatePrice);
            //foreach(Product p in list)
            //{
            //    Console.WriteLine(p);
            //}

            //// Example 2
            //Action<Product> act = UpdatePrice;
            //list.ForEach(act);
            //foreach (Product p in list)
            //{
            //    Console.WriteLine(p);
            //}

            //// Example 3
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };
            //list.ForEach(act);
            //foreach (Product p in list)
            //{
            //    Console.WriteLine(p);
            //}

            // Example 4
            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }



        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
