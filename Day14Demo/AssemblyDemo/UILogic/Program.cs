using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary;

namespace UILogic
{
    [Doctor(Name ="Ravi", CheckedOnDate ="12/02/2025")]
    //[Doctor(Name = "Shashi", CheckedOnDate = "2/02/2025")]
    //[Doctor(Name = "Neha", CheckedOnDate = "16/02/2025")]
    public class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Enter 1st Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            SomeLogic logic = new SomeLogic();

            int numResult = logic.AddMe(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {numResult}");

            Doctor atr=(Doctor)Attribute.GetCustomAttribute(typeof(Program), typeof(Doctor));
            if (atr == null)
            {
                Console.WriteLine("Author attribute not applied to student");
            }
            else
            {
                Console.WriteLine("Doctor Name: "+atr.Name);
                Console.WriteLine("Checked on date: "+atr.CheckedOnDate);
            }


                Console.ReadLine();
        }
    }
}

