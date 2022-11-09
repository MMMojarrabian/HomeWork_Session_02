using System;
namespace myproject
{

    class Project
    {
      static void Main (string[] args)
      {
          String  number = Console.ReadLine();
          int num = Convert.ToInt32(number);
          num = num + 10;
          Cosole.WriteLine(num);
      }
    }
}