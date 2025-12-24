using System;

namespace Assignment2;

public class CabDetails:Cab
{

    public bool ValidateBookingID()
    {

        bool isValid = false;
        if (BookingID.Length == 6)
        {
            if (BookingID.StartsWith("AC@"))
            {
                string digitsPart = BookingID.Substring(3);
                if (int.TryParse(digitsPart, out int n) && digitsPart.Length == 3)
                {
                    isValid = true;
                }
            }
        }
        return isValid;


    
    }
    public double CalculateFareAmount()
    {
            double fare = 0;
            double pricePerKm = 0;
            switch (CabType)
            {
                case "Hatchback":
                    pricePerKm = 10;
                    break;
                case "Sedan":
                    pricePerKm = 20;
                    break;
                case "SUV":
                    pricePerKm = 30;
                    break;
                default:
                    pricePerKm = 0;
                    break;
            }
            fare = Math.Floor(((Distance * pricePerKm) + Math.Sqrt(WaitingTime))*100)/100;//Floor method is used to round off to 2 decimal places
            //method 2 =>  double fare = Math.Round((Distance * pricePerKm) + Math.Sqrt(WaitingTime),2);

            return fare;
        
    }

}
