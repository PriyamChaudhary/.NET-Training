using System;
namespace Assignment2;
public class Program
{
    public static void Main(string[] args)
    {

        CabDetails cabDetails = new CabDetails();

        Console.WriteLine("Enter Booking ID:");
        cabDetails.BookingID = Console.ReadLine();

        if (cabDetails.ValidateBookingID())
        {
            Console.WriteLine("Enter Cab Type:");
            cabDetails.CabType = Console.ReadLine();

            Console.WriteLine("Enter Distance (in km):");
            cabDetails.Distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Waiting Time in minutes:");
            cabDetails.WaitingTime = Convert.ToInt32(Console.ReadLine());

            double fareAmount = cabDetails.CalculateFareAmount();
            Console.WriteLine($"Fare Amount: {fareAmount}");


        }
        else
        {
            Console.WriteLine("Invalid booking id");
        }

    }
}