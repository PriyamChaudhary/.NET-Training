using System;
namespace ShopValidator;

public class Program
{
    public static void Main(string[] args)
    {
        GadgetValidatorUtil gObj=new GadgetValidatorUtil();
        Console.WriteLine("No of entries:");
        int n=int.Parse(Console.ReadLine());

        for(int i = 1; i <=n; i++)
        {
            Console.WriteLine($"Entry No: {i}");
            try
            {
                string[] input=Console.ReadLine().Split(':');

                string gId=input[0];
                string name=input[1];
                int warranty=int.Parse(input[2]);

                gObj.ValidateGadgetId(gId);
                gObj.ValidateWarrantyPeriod(warranty);
                Console.WriteLine("Warranty Accepted, stock updated");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}