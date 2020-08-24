using System;

namespace ConstructorWithProperty
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
        class Program
    {
        static void Main(string[] args)
        {
                BirthdayInfo birth = new BirthdayInfo()
                {
                    Name = "수영",
                    Birthday = new DateTime(2020, 10, 19)
                };
                Console.WriteLine(birth.Name);
                Console.WriteLine(birth.Birthday.ToShortDateString());
                Console.WriteLine(birth.Age);
            }
       }
    }
}
