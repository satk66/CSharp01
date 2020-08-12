using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;


namespace stringFormat
{
    class Program
    {
        private static object nama;

        static void Main(string[] args)
        {
            /*
            string result1 = string.Format("ABC(0, 10)GHI", "DEF");
            string result2 = string.Format("ABC(0, -10)GHI", "DEF");
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            string fmt = "{0,-20}{1,-15},{2,30}";
            Console.WriteLine(fmt, "Publisher", "Author", "Title");
            Console.WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            Console.WriteLine(fmt, "Hanbit", "Sanghyun Park", "C# 7.0 Programming");
            


            //10진수
            WriteLine("10진수: {0:D}", 123);
            WriteLine("10진수: {0:D5}", 123);
            //16진수
            WriteLine("16진수: {0:X}", 0xFF1234);
            WriteLine("16진수: {0:X8}", 0xFF1234);
            //숫자
            WriteLine("숫자 : {0:N}", 123456789);
            WriteLine("숫자 : {0:N0}", 123456789);
            //고정 소수점
            WriteLine("고정소수정: {0:F}", 123.45);
            WriteLine("고정소수정: {0:F5}", 123.45);
            //지수
            WriteLine("지수: {0:E}", 123.456789);
            */

            DateTime dt = new DateTime(2020, 8, 12, 11, 4, 22);
            WriteLine("12시간형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            WriteLine("24시간형식: {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));

            int number = 30100;
            string name = "마마마";
            WriteLine($"{number:D}{nama,10}");
            Read();
        }
    }
}
