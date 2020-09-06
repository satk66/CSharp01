using System;
using System.IO;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create));
            sw.Write(int.MaxValue);
            sw.Write("Good Morning");
            sw.Write(uint.MaxValue);
            sw.Write("안녕하세여");
            sw.Write(double.MaxValue);
            sw.Close();

            StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));
            Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");
            while (sr.EndOfStream == false) 
                Console.WriteLine(sr.ReadLine());

            sr.Close();
        }
    }
}
