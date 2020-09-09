using System;
using System.Collections.Generuc;
using System.Linq;

class Profile
{
  public string Name{ get;set;}

  public int Height{ get;set;}
}

class MainClass {
  public static void Main (string[] args) {
     Profile[] arrProfile = {
      new Profile(){Name="정우성",Height=186},
      new Profile(){Name="김태희",Height=158},
      new Profile(){Name="고현정",Height=172},
      new Profile(){Name="이문세",Height=178},
      new Profile(){Name="하하",Height=171},
      
    };
    Console.WriteLine("### 똑똑하게 추출###");
    var Profile2 = Profile in arrProfile
        where Profile.Height <175
        orderby Profile.Height
        select Profile;
    foreach(var Profile in Profile2)
      Console.WriteLine("{0},{1}",Profile.Name,Profile.Height);

  }
}