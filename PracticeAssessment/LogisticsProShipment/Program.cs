using System;
using System.Text.RegularExpressions;

namespace LogisticsProShipment;

public class Program
{
    public static void Main(string[] args)
    {
        
        ShipmentDetails sObj=new ShipmentDetails();
        sObj.ShipmentCode=Console.ReadLine();
        bool isValid=sObj.ValidateShipmentCode();
        if (!isValid)
        {
            Console.WriteLine("Invalid Shipment Code");
            return;
        }
        
            sObj.TransportMode=Console.ReadLine();
            sObj.Weight=double.Parse(Console.ReadLine());
            sObj.StorageDays=int.Parse(Console.ReadLine());
            
            double cost=sObj.CalculateTotalCost();
            Console.WriteLine($"Total Cost is {cost}");
        

        }
    }
