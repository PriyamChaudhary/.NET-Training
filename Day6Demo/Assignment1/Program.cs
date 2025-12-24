using System;
namespace Assignment1;
public class Program
{
    public static void Main(string[] args)
    {
       
       System.Console.WriteLine("Enter the title:");//user inputs
       string title=Console.ReadLine();
       System.Console.WriteLine("Enter the author:");
       string author=Console.ReadLine();
       System.Console.WriteLine("Enter the number of pages:");
       int numPages=Convert.ToInt32(Console.ReadLine());
       System.Console.WriteLine("Enter the due date:");
       DateTime dueDate=Convert.ToDateTime(Console.ReadLine());
       System.Console.WriteLine("Enter the returned date:");
       DateTime returnedDate=Convert.ToDateTime(Console.ReadLine());

       Book book=new Book(title,author,numPages,dueDate,returnedDate);//object creation and passing values to constructor


       System.Console.WriteLine("Enter the number of days to read:");
       int daysToRead=Convert.ToInt32(Console.ReadLine());
       System.Console.WriteLine("Enter the daily late fee rate:");
       double dailyLateFeeRate=Convert.ToDouble(Console.ReadLine());
       double averagePagesReadPerDay=book.AveragePagesReadPerDay(daysToRead);//method calls for average pages and late fee
       System.Console.WriteLine($"Average Pages Read Per Day:{averagePagesReadPerDay}");
       double lateFee=book.CalculateLateFee(dailyLateFeeRate);
       System.Console.WriteLine($"Late Fee:{lateFee}");







    }
}