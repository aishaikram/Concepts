using System;
using System.Collections.Generic;
using System.IO;

namespace Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string Path = @"C:\Windows";

            Console.WriteLine($"Show Large Files with LINQ at the path {Path}");
            Console.WriteLine("-----------------------------------------------");
            IEnumerable<FileInfo> files = MyLinq.ShowLargeFiles(Path);

            foreach (var file in files)
            {
                Console.WriteLine($"{file.Name,-20}, {file.Length,10:N0}");
            }

            string s = "200.45";
            double val = s.ToDouble();
           
            Console.ReadLine();
        }
    }
}
