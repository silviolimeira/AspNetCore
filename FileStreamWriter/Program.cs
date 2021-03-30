﻿using System;
using System.IO;

namespace FileStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"d:\temp\file1.txt";
            string targetPath = @"d:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            } catch (IOException ioe)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ioe.Message);
            }
        }
    }
}
