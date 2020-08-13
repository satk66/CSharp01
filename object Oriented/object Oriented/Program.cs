using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_Oriented
{
    class Cat
    {
        public Cat()
         {

            Name = "";
            Color = " ";
    }


        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
        public Cat(string _Name , string _Color)
        {

            Name = _Name;
            Color = _Color;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat Kitty = new Cat();
            Kitty.Color = "하얀색";
            Kitty.Name = "키티";
            Kitty.Meow();
            Console.WriteLine($"{Kitty.Name} : {Kitty.Color}");

            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");

            Cat nero = new Cat("네로""검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
            Console.Read();
        }
    }
}
