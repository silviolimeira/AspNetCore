﻿using System;
using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"d:\temp\file1.txt";
            string targetPath = @"d:\temp\file2.txt";

            try
            {
                //FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ioe.Message);
            }
        }
    }
}
