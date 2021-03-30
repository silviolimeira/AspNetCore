using Enterprise1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Enterprise1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int nemployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nemployees; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsourced == 'y')
                {
                    Console.Write("Aditional charge: ");
                    double aditionalcharge 
                        = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    OutSourceEmployee o = new OutSourceEmployee(name, hours, valueperhour, aditionalcharge);
                    employees.Add(o);
                } else
                {
                    Employee e = new Employee(name, hours, valueperhour);
                    employees.Add(e);
                }

            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee e in employees)
            {
                Console.WriteLine($"{e.Name} - $ {e.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
