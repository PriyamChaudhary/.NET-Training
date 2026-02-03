using System;
 

 class Program
{
    public static void Main(string[] args)
    {
        double radius =Convert.ToDouble(Console.ReadLine());
        double area = CalculateCircleArea(radius);
        Console.WriteLine(area);
    }
    public static double CalculateCircleArea(double radius)
    {
        double area = Math.PI * radius * radius;
        return Math.Round(area,2,MidpointRounding.AwayFromZero);
    }
}
