using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Method
{
    class Calculator
    {
        public static int Plus(int a, int b = 0)
        {
            return a + b;
        }
        public static int Plus(int a, int b,int c)
        {
            return a + b +c;
        }
        public static double Plus(double a,double b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        public static void Sum(params int[] args)
        {
            int sum = 0;
            for(int i=0; i < args.Length; i++)
            {
                sum += args[i];
            }
            return sum;
        }
    }
    class Product
    {
        private int priec = 100;
        public ref int GetPrice()
        {
            return ref priec;
        }
        public void PrintPrice()
        {
            WriteLine($"Price :{price}");
        }
    }
    public static void Mean(
        double a, double b, double c,
        double d, double e, double mean)
    {
        mean = (a + b + c + d + e) / 5;
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int result = Calculator.Plus(3,4);
            WriteLine(result);
            result = Calculator.Minus(5, 2);
            WriteLine(result);

            WriteLine("a={0},b={1}", a, b);
            Swap(ref a, ref b);
            WriteLine("a={0},b={1}", a, b);
            

            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            carrot.PrintPrice();
            ref_local_price = 200;
            carrot.PrintPrice();

            int a= 3, int b = 4;
            int result = Calculator.Plus(a, b);
            WriteLine(result);

            result = Calculator.Plus(1, 2, 3);
            WriteLine(result);

            double result2 = Calculator.Plus();
            WriteLine(result2);

            WriteLine(Calculator.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13));
             

            WriteLine(Calculator.Plus(3);
            WriteLine(Calculator.Plus(3, 4));
            */


            double mean = 0;

            mean(1, 2, 3, 4, 5, mean);
            WriteLine("평균 : {0}", mean);

            Read();
        }
    }
}
