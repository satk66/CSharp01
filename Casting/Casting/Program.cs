using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        class Mamal
        {
            public Mamal()
            {
                Console.WriteLine("Hello world");
            }
            public void Nurse()
            {
                Console.WriteLine("동물을 길러요");
            }
        }
        class Dog : Mamal
        {
            public Dog()
            {
                Console.WriteLine("Hello Dog");
            }
            public void Bark()
            {
                Console.WriteLine("멍멍");
            }
            class Cat : Mamal
            {
                public Cat()
                {
                    Console.WriteLine("Hello Cat");
                }
                public void Bark()
                {
                    Console.WriteLine("냐옹");
                }
            }

            static void Main(string[] args)
            {
                Mamal m = new Mamal();
                Dog d = new Dog();
                m.Nurse();
                d.Nurse(); d.Bark();

                Mamal mc = new Cat();
                mc.Nurse();
                
                

                Console.Read();
            }
        }
    }
}
