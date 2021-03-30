using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\temp\myFolder";

            try
            {
                // example 1
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folder)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("end example 1 =================");
                Console.WriteLine();
                // example 2
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("end example 2 =================");
                Console.WriteLine();

                // EXAMPLE 3
                Directory.CreateDirectory(path + @"\newFolderX");

            }
            catch (IOException ioe)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ioe.Message);
            }
        }
    }
}
