using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using IComparableExample.Entities;

namespace IComparableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch(IOException ioe)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ioe.Message);
            }
        }
    }
}
