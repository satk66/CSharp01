﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    class Program
    {
        partial class Myclass
        {
            public void Method1()
            {
                Console.WriteLine("Method1");
            }
            public void Method2()
            {
                Console.WriteLine("Method2");
            }
        }

        partial class MyClass
        {
            public void Method3()
            {
                Console.WriteLine("Method3");
            }
            public void Method4()
            {
                Console.WriteLine("Method4");
            }
        }
     
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            obj.Method4();
        }
    }
}
