using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILogic;

public class Program
{
    public static void Main(string[] args)
    {
        int num1;
        int num2;

        Console.WriteLine("Enter 1st Number: ");
        num1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 2nd Number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        SomeLogic logic = new SomeLogic();

    }
}
