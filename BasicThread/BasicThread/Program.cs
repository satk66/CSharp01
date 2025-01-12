﻿using System;
using System.Threading;

namespace BasicThread
{
    class Program
    {
        static void DoSomething()
        {
            for (int i=0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));
            Console.WriteLine("Start thread...");
            t1.Start();
            for (int i=0; i < 5; i++)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(10);
            }
            Console.WriteLine("Wating until thread Stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
