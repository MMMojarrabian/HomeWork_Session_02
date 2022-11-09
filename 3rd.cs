using System;
namespace myproject
{

    class Project
    {
      static void Main (string[] args)
      {
          String a = Console.ReadLine(); 
          String b = Console.ReadLine();
          String c = Console.ReadLine();
          
          int num1 = Convert.ToInt32(a);
          int num2 = Convert.ToInt32(b);
          int num3 = Convert.ToInt32(c);

          if (a+b>c && a+c>b && b+c>a)
          {
             Mohit(a,b,c)
          }
          else {Console.WriteLine("NO")}

       Private Void Mohit(int x, int y , int z) 
       {
        int w = x + y + z;
        Console.WriteLine(w); 
       } 


      }
    }
}

///////////////////


