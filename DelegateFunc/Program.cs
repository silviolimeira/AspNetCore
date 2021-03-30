using System;
using System.Collections.Generic;
using DelegateFunc.Entities;
using System.Linq;

namespace DelegateFunc
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

            //// Exampe 1
            //List<string> result = list.Select(NameUpper).ToList();
            //foreach(string s in result)
            //{
            //    Console.WriteLine(s);
            //}

            //// Exampe 2
            //Func<Product, string> func = NameUpper;
            //List<string> result = list.Select(func).ToList();
            //foreach (string s in result)
            //{
            //    Console.WriteLine(s);
            //}

            //// Exampe 3
            //Func<Product, string> func = p => p.Name.ToUpper();
            //List<string> result = list.Select(func).ToList();
            //foreach (string s in result)
            //{
            //    Console.WriteLine(s);
            //}

            // Exampe 4 inline
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }



        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
