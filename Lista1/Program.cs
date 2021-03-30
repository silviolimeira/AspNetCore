using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            Console.Write("How many employees will be registered? ");
            int tot = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < tot; i++)
            {
                Console.WriteLine("Emprloyee #{0}: ", i+1);
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                employees.Add(new Employee { Id = id, Name = name, Salary = salary });

            }

            Console.WriteLine("List of emplyees:");
            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            Console.Write("Enter the employee id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());
            int index = employees.FindIndex(x => x.Id == id);

            if (index < 0)
            {
                Console.WriteLine("This id does not exist!");
            } else
            {
                Console.Write("Enter the percentage: ");
                float perc = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee employee = employees[index];
                employee.Salary += employee.Salary * (decimal)perc / 100;
            }


            Console.WriteLine();
            Console.WriteLine("List of emplyees:");
            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
