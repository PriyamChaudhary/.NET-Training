using System;
namespace MediSure_Clinic;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("================== MediSure Clinic Billing ==================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");
            string? option = Console.ReadLine();
            if (!int.TryParse(option, out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    PatientBill.CreateNewBill();
                    break;
                case 2:
                    PatientBill.ViewLastBill();
                    break;
                case 3:
                    PatientBill.ClearLastBill();
                    break;
                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter a valid choice.");
                    break;
            }

            Console.WriteLine();
        }
    }
}


    

























































































