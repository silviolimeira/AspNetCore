using System;
using System.IO;

namespace PathExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPath = @"d:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(myPath));
            Console.WriteLine("GetFileName: " + Path.GetFileName(myPath));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(myPath));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
