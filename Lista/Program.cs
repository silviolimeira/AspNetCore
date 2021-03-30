using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();

            //List<string> list2 = new List<string> { "Maria", "Silvio" };

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("list.Count: " + list.Count);
            Console.WriteLine();

            string s1 = list.Find(Test);  // predicado - função lambda
            Console.WriteLine("First A: " + s1);
            Console.WriteLine();

            string s2 = list.Find(x => x[0] == 'B');  // função lambda - função anonima
            Console.WriteLine("First B: " + s2);
            Console.WriteLine();

            string s3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s3);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("---------------------");

            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------");
            list.Add("Um");
            list.Add("Dois");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------");
            list.RemoveAt(2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------");
            list.Add("Tres");
            list.Add("Quatro");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------");
            list.RemoveRange(2,2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }



        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
