using System;

namespace ConditonalApp;

public class LargestOfThree
{
  public static void LargestMain()
    {
        int num1=Int32.Parse(Console.ReadLine());
        int num2=Int32.Parse(Console.ReadLine());
        int num3=Int32.Parse(Console.ReadLine());
        if (num1 > num2)
        {
            if(num1>num3) System.Console.WriteLine("Num1 is largest");
            else System.Console.WriteLine("Num3 is largest");
        }
        else
        {
            if (num2 > num3) System.Console.WriteLine("Num2 is largest");
            else System.Console.WriteLine("Num3 is largest");
        }
    }
}
