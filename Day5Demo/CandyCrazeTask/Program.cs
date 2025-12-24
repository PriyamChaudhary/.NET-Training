using System;
namespace CandyCrazeTask;
class Program
{
    public Candy CalculateDiscountedPrice(Candy candy)
    {
        switch (candy.Flavour)
        {
            case "Lemon":
                candy.Discount = 10;
                break;
            case "Strawberry":
                candy.Discount = 15;
                break;
            case "Mint":
                candy.Discount = 5;
                break;
            default:
                candy.Discount = 0.0;
                break;
        }
        candy.TotalPrice = candy.Quantity * candy.PricePerPiece;
        candy.Discount = candy.TotalPrice-(candy.TotalPrice * candy.Discount) / 100;
        return candy;
    }
    public static void Main(string[] args)
    {
        
        Candy candy = new Candy();

        Console.WriteLine("Enter the Candy Flavour:");
        candy.Flavour = Console.ReadLine();

        if(candy.ValidateCandyFlavour())
        {
            Console.WriteLine("Enter the Quantity:");
            candy.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Price per piece:");
            candy.PricePerPiece = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();  
            candy = program.CalculateDiscountedPrice(candy);
            Console.WriteLine($"Flavour: {candy.Flavour}");
            Console.WriteLine($"Quantity: {candy.Quantity}");
            Console.WriteLine($"Price per piece: {candy.PricePerPiece}");
            Console.WriteLine($"Total Price: {candy.TotalPrice}");
            Console.WriteLine($"Total Price after discount: {candy.Discount}");


        }
        else
        {
            Console.WriteLine("Invalid Candy Flavour");
        }
    }
}