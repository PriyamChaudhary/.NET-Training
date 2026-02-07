using System;
namespace Q1HotelBillingSystem;

public class Program
{
    public static void Main(string[] args)
    {
        // Deluxe Room Input
        Console.WriteLine("Enter Deluxe Room Details:");
        Console.Write("Guest Name: ");
        string deluxeGuest = Console.ReadLine();

        Console.Write("Rate per Night: ");
        double deluxeRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nights Stayed: ");
        int deluxeNights = Convert.ToInt32(Console.ReadLine());

        Console.Write("Joining Year: ");
        int deluxeJoiningYear = Convert.ToInt32(Console.ReadLine());

        // Suite Room Input
        Console.WriteLine("Enter Suite Room Details:");
        Console.Write("Guest Name: ");
        string suiteGuest = Console.ReadLine();

        Console.Write("Rate per Night: ");
        double suiteRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nights Stayed: ");
        int suiteNights = Convert.ToInt32(Console.ReadLine());

        Console.Write("Joining Year: ");
        int suiteJoiningYear = Convert.ToInt32(Console.ReadLine());

        // Room objects
        HotelRoom deluxeRoom = new HotelRoom("Deluxe", deluxeRate, deluxeGuest);
        HotelRoom suiteRoom = new HotelRoom("Suite", suiteRate, suiteGuest);

        // years of membership
        int deluxeMembership = ((IRoom)deluxeRoom).CalculateMembershipYears(deluxeJoiningYear);
        int suiteMembership = ((IRoom)suiteRoom).CalculateMembershipYears(suiteJoiningYear);

        // bill calculation
        double deluxeBill = deluxeRoom.CalculateTotalBill(deluxeNights, deluxeJoiningYear);
        double suiteBill = suiteRoom.CalculateTotalBill(suiteNights, suiteJoiningYear);

        
        Console.WriteLine("Room Summary:");
        Console.WriteLine($"Deluxe Room: {deluxeGuest}, {deluxeRate} per night, Membership: {deluxeMembership} years");
        Console.WriteLine($"Suite Room: {suiteGuest}, {suiteRate} per night, Membership: {suiteMembership} years");

        Console.WriteLine("Total Bill:");
        Console.WriteLine($"For {deluxeGuest} (Deluxe): {deluxeBill}");
        Console.WriteLine($"For {suiteGuest} (Suite): {suiteBill}");
    }
}
