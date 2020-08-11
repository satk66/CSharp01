﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum DialogResult {YES, NO , CANCEL, CONFIRM, OK }
        static void Main(string[] args)
        {
            /*
            sbyte a = 127; Console.WriteLine(a);
            int b = (int)a; Console.WriteLine(b);

            int x = 128;
            Console.WriteLine(x);

            sbyte y = (sbyte)x;
            Console.WriteLine(y);

            float a2 = 69.6875f;
            Console.WriteLine("a : {0}", a);

            double b2 = (double)a;
            Console.WriteLine("b : {0}", b);

            float x2 = 0.1f;
            Console.WriteLine("x2 : {0}", x2);
            double y2=(double)x2; Console.WriteLine("y2 : {0}", y2);

            float c3 = 0.9f; Console.WriteLine(c3);
            float d3 = 1.1f; Console.WriteLine(d3);


            int a4 = 123;
            string b4 = a4.ToString();
            float c4 = 3.14f;
            string d4 = c4.ToString();

            string e4 = "123456";
            int f4 = Convert.ToInt32(e4); Console.WriteLine(f4);
            string g4 = "1.2345";
            float h4 = float.Parse(g4); Console.WriteLine(h4);

            const int MAX_INT = 2147483647;
            const int MIX_INT = -2147483647;

            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);

            int? a5 = 3;
            Console.WriteLine(a5.HasValue);
            Console.WriteLine(a5 != null);
            Console.WriteLine(a5.Value);
            */

            var a6 = 20;
            Console.WriteLine("Type : {0},Value : {1}", a6.GetType(), a6);
            var b6 = 3.1414213;
            Console.WriteLine("Type : {0},Value : {1}", b6.GetType(), b6);
            var c6 = "Hello world";
            Console.WriteLine("Type : {0},Value : {1}", c6.GetType(), c6);
            var d6 = new int[] {10, 20,30};
            Console.WriteLine("Type : {0},Value : {1}", d6.GetType(), d6);
            foreach (ver e in d6)
            {
                Console.WriteLine("{0}", e);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
