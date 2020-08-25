using System;

namespace PropertiesInInterface
{
    interface INameValue
    {
        string Name
        {
            get; set; //구현이 안된 가상의 프로퍼티
        }
        string Value
        {
            get; set;
        }
    }

    class NameValue : INameValue
    {
       public string Name
        {
            get; set; // 구현이 된 자동완성 프로퍼티
        }
       public string Value
        {
            get; set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NameValue name = new NameValue() { Name = "이름", Value = "마마미" };
            NameValue height = new NameValue() { Name = "키", Value = "175cm" };
            NameValue weight = new NameValue() { Name = "몸무게", Value = "150kg" };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");
        }
    }
}
