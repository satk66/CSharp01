using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
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
                public void Meow()
                {
                    Console.WriteLine("냐옹");
                }
            }
            static void Main(string[] args)
            {
                Mamal mamal = new Dog();
                Dog dog;
                if (mamal is Dog)
                {
                    dog = (Dog)mamal;

                }
                    Mamal mamal1 = new Cat();
                    Cat cat = mamal1 as Cat;
                if(cat != null)
                {
                    cat.Meow();
                }
                Cat cat2 = mamal as Cat;
                if (cat2 != null)
                {
                    cat2.Meow();
                }
                else
                {
                    Console.WriteLine("cat2 is not a Cat");                }

                    Console.Read();

                
            }
        }
    }
}
