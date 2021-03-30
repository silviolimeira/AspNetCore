using System;

namespace VarSwitchExpressao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(); 
            Console.WriteLine("Exemplo var - inferência de tipos ========");
            var i = 10;
            var d = 1.50;
            var s = "string";
            Console.WriteLine(i);
            Console.WriteLine(d);
            Console.WriteLine(s);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Exemplo switch-case =======================");
            int x = int.Parse(Console.ReadLine());
            string day;
            
            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Sturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine("Day: " + day);


        }
    }
}
