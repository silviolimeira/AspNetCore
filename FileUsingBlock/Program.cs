using System;
using System.IO;

namespace FileUsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Example 1
            //string path = @"d:\temp\file1.txt";
            //try
            //{

            //    using (FileStream fs = new FileStream(path, FileMode.Open))
            //    {
            //        using (StreamReader sr = new StreamReader(fs))
            //        {
            //            while (!sr.EndOfStream)
            //            {
            //                string line = sr.ReadLine();
            //                Console.WriteLine(line);
            //            }
            //        }
            //    }
            //}
            //catch (IOException ioe)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(ioe);
            //}

            // Example 2
            string path = @"d:\temp\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ioe);
            }


        }
    }
}
