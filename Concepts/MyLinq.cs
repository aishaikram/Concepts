using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Concepts
{
    internal static class MyLinq
    {
        internal static IEnumerable<FileInfo> ShowLargeFiles(string path)
        {
            //var Dir = new DirectoryInfo(path);
            //var query = from file in Dir.GetFiles()
            //            orderby file.Length descending
            //            select file;
            //var count = 3;
            //foreach(var file in query.Take(count))
            //{
            //    Console.WriteLine($"{file.Name, -20}, {file.Length,10:N0}");
            //}

            var Dir = new DirectoryInfo(path);
            var query = Dir.GetFiles()
                           .OrderByDescending(f => f.Length)
                           .Take(5);

            return query;
            

        }
    }
}
