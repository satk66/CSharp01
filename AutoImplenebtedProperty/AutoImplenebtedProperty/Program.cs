using System;

namespace AutoImplenebtedProperty
{
    class Program
    {
        class BirthdayInfo
        {
            public string Name
            {
                get;
                set;
            } = "Unknown";
            public DateTime Birthday
            {
                get;
                set;
            } = new DateTime(2000, 10, 19);
            public int Age
            {
                get
                {
                    return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
                }
            }
        }
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            Console.WriteLine(birth.Name);
            Console.WriteLine(birth.Birthday);
            Console.WriteLine(birth.Age);
            birth.Name = "수영";
            birth.Birthday = new DateTime(2020, 10, 19);
            Console.WriteLine(birth.Name);
            Console.WriteLine(birth.Birthday);
            Console.WriteLine(birth.Age);
        }
    }
}
