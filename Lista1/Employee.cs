using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Lista1
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public void Promotion(float perc)
        {
            Salary = Salary * (decimal)perc / 100;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
