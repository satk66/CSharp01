﻿using System;
using System.Linq;
using System.IO;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory;
            if (args.Length < 1)
            {
                directory = ".";
            }
            else
            {
                directory = args[0];
            }
            Console.WriteLine($"{directory} directory Info");
            Console.WriteLine(" - Dirextories :");
            var directories = (from dir in Directory.GetDirectories(directory)
                               let info = new DirectoryInfo(dir)
                               select new
                               {
                                   Name = info.Name,
                                   Attribute = info.Attributes
                               }).ToList() ;
            foreach (var d in directories)
                Console.WriteLine($"{d.Name} : {d.Attribute}");

            Console.WriteLine("- Files : ");
            var files = (from file in Directory.GetFiles(directory)
                         let info = new FileInfo(file)
                         select new
                         {
                             Name = info.Name,
                             FileSize = info.Length,
                             Attributes = info.Attributes
                         }).ToList();
            foreach (var f in files)
                Console.WriteLine($"{f.Name} : {f.FileSize},{f.Attributes}");
        }
    }
}
