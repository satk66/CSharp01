using System;

namespace Anonymous_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "마마마", Age = 1234 };
            Console.WriteLine($"Name:{a.Name}, Age:{a.Age}");

            var b = new { Subject = "c#", Scores = new int[] { 90, 80, 70, 60 } }; 
            Console.WriteLine($"Subject:{b.Subject},Scores: ");
            foreach (var score in b.Scores)
            {
                Console.WriteLine($"{score}");
            }

        }
    }
}
