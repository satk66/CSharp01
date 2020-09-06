using System;
using System.Linq;
using System.Runtime;
using System.Text.RegularExpressions;

namespace MinMaxAvg
{
    class Program
    {
        class Profile
        {
            public string Name { get; set; }
            public int Height { get; set; }
        }
        
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성", Height=186},
                 new Profile(){Name="김태희", Height=156},
                  new Profile(){Name="고현정", Height=172},
                   new Profile(){Name="이문세", Height=178},
                    new Profile(){Name="하하", Height=171}
            };
            var heightstat = from Profile in arrProfile
                             group Profile by Profile.Height < 175 into g
                             select new
                             {
                                 Group = g.Key == true ? "175미만" : "175이상",
                                 Count = g.Count(),
                                 Max = g.Max(Profile => Profile.Height),
                                 Min = g.Min(Profile => Profile.Height),
                                 Average = g.Average(Profile => Profile.Height)
                             };
            foreach(var stat in heightstat)
            {
                Console.Write("{0} - Count:{1},Max:{2},Min:{3},Average:{4}",
                    stat.Group, stat.Count, stat.Max, stat.Min, stat.Average);
            }
        }
    }
}
