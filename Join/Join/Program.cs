using System;
using System.Linq;

namespace Join
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Product
    {
        public string Title{ get; set; }
        public string Star { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name ="정우성",Height=187},
                new Profile(){Name ="김태희",Height=158},
                new Profile(){Name ="고현정",Height=172},
                new Profile(){Name ="이문세",Height=176},
                new Profile(){Name ="하하",Height=171}
            };
            Product[] arrProduct = {
                new  Product(){Title ="비트",Star="정우성"},
                new  Product(){Title="CF 다수",Star="김태희"},
                new Product(){Title ="아이리스",Star="김태희"},
                new  Product(){Title="모래시계",Star="고현정"},
                new  Product(){Title="solo 예찬",Star="이문세"}
            };
            // 내부조인
            var listProfile = from Profile in arrProfile
                              join Product in arrProduct on Profile.Name equals Product.Star
                              select new
                              {
                                  Name = Profile.Name,
                                  Height = Profile.Height,
                                  Work = Product.Title
                              };
            Console.WriteLine("--- 내부 조인 결과 ---");
            foreach(var profile in listProfile)
            {
                Console.WriteLine("이름:{0},작품:{1},키{2}cm", profile.Name, profile.Work, profile.Height);
            }
            //외부조인
            listProfile = from Profile in arrProfile
                          join Product in arrProduct on Profile.Name equals Product.Star into ps
                          from Product in ps.DefaultIfEmpty(new Product() { })
                          select new
                          {
                              Name = Profile.Name,
                              Height = Profile.Height,
                              Work = Product.Title
                          };
            Console.WriteLine("--- 외부 조인 결과 ---");
            foreach(var profile in listProfile)
            {
                Console.WriteLine("이름:{0},작품:{1},키{2}cm", profile.Name, profile.Work, profile.Height);
            }
        }
    }
}
