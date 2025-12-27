using System;

namespace QuickMartProfitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("================== QuickMart Traders ==================");
                Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
                Console.WriteLine("2. View Last Transaction");
                Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");
                string? option = Console.ReadLine();
                if (!int.TryParse(option, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    Console.WriteLine();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        SaleTransaction.CreateNewTransaction();
                        break;
                    case 2:
                        SaleTransaction.ViewLastTransaction();
                        break;
                    case 3:
                        SaleTransaction.CalculateProfitLoss();
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
}
