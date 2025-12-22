using System;

namespace ConditonalApp;

public class LeapYear
{
public static void LeapMain()
    {
        //Determine if a year is leap (Divisible by 400 OR (Divisible by 4 and NOT 100)).
        int year=Int32.Parse(Console.ReadLine());
        if(year%400==0 || (year%4==0 && year % 100 != 0))
        {
            System.Console.WriteLine("Leap Year");
        }
        else
        {
            System.Console.WriteLine("Not a Leap Year");
        }
    }
}
