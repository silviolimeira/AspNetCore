using System;
using System.IO;

namespace FileStreamAndStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Example 1
            //string path = @"d:\temp\file1.txt";
            //FileStream fs = null;
            //StreamReader sr = null;

            //try
            //{
            //    fs = new FileStream(path, FileMode.Open);
            //    sr = new StreamReader(fs);
            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //}
            //catch (IOException ioe)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(ioe.Message);
            //} finally
            //{
            //    if (sr != null) sr.Close();
            //    if (fs != null) fs.Close();
            //}

            // Example 2
            string path = @"d:\temp\file1.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ioe.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }




        }
    }
}
