using System;
namespace Assignment3App;
public class Program
{
    int choice;
    public static void Main(string[] args)
    {
        System.Console.WriteLine("1. Laptop");
        System.Console.WriteLine("2. Desktop");
        System.Console.WriteLine("Enter your choice: ");
        int choice=Convert.ToInt32(Console.ReadLine());

    switch(choice){

        case 1:
        {
        Laptop laptop=new Laptop();
        System.Console.WriteLine("Enter the processor: ");
        laptop.Processor=Console.ReadLine();

        System.Console.WriteLine("Enter the Ram size: ");
        laptop.RamSize=Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the HardDisk size: ");
        laptop.HardDiskSize=Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the GraphicCard size: ");
        laptop.GraphicCard=Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the Display size: ");
        laptop.DisplaySize=Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the Battery volt: ");
        laptop.BatteryVolt=Convert.ToInt32(Console.ReadLine());
        double laptopPrice=laptop.LaptopPriceCalculation();

        System.Console.WriteLine("The Laptop Price is: "+laptopPrice);

        break;
        }

        case 2:
        {
        Desktop desktop=new Desktop();  
        System.Console.WriteLine("Enter the processor: ");
        desktop.Processor=Console.ReadLine();
        

        System.Console.WriteLine("Enter the Ram size: ");
        desktop.RamSize=Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the HardDisk size: ");
        desktop.HardDiskSize=Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the GraphicCard size: ");
        desktop.GraphicCard=Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the Monitor size: ");
        desktop.MonitorSize=Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the PowerSupply volt: ");
        desktop.PowerSupplyVolt=Convert.ToInt32(Console.ReadLine());
        double desktopPrice=desktop.DesktopPriceCalculation();

        System.Console.WriteLine("The Desktop Price is: "+desktopPrice);

        break;   
        }      

    }
}
}