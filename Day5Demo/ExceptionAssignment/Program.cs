using System;
namespace ExceptionAssignment;
public class Program
{
    public static void Main(string[] args)
    {
        Cake cakeObj=new Cake();
        System.Console.WriteLine("Enter the flavour:");
        cakeObj.Flavour=System.Console.ReadLine();
        System.Console.WriteLine("Enter the quantity in kg:");
        cakeObj.QuantityInKg=Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Enter the price per kg:");
        cakeObj.PricePerKg=Convert.ToDouble(System.Console.ReadLine());
        try
        {
            bool orderStatus=cakeObj.CakeOrder();
            if(orderStatus)
            {
                double finalPrice=cakeObj.CalculatePrice();
                System.Console.WriteLine("The final price of the cake is: "+finalPrice);
            }
        }
        catch(InvalidFlavourException ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        catch(InvalidQuantityException ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}