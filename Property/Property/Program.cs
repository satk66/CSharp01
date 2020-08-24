using System;

namespace Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
         get {   //읽기 전용
                return name;
                 
            }
            set
            { //쓰기전용
                name = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "마마"; //Name 의 set
            birth.Birthday = new DateTime(2000, 10, 19); //set
            Console.WriteLine(birth.Name); //Name 의 get
            Console.WriteLine(birth.Birthday); //Birthday 의 get
            Console.WriteLine(birth.Age); // Age의 get
        }
    }
}
