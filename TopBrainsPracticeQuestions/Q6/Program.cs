using System;

class Program
{
    public static void Main(string[] args)
    {
        int num1=Convert.ToInt32(Console.ReadLine());
        int num2=Convert.ToInt32(Console.ReadLine());
        int num3=Convert.ToInt32(Console.ReadLine());
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