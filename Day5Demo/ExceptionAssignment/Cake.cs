using System;

namespace ExceptionAssignment;

public class Cake
{
    public string Flavour { get; set; }
    public int QuantityInKg { get; set; }
    public double PricePerKg { get; set; }

    public bool CakeOrder()
    {
        bool isValid=false;
        if(Flavour=="Chocolate" || Flavour=="Red Velvet" || Flavour == "Vanilla")
        {
            isValid=true;
            if (QuantityInKg > 0)
            {
                isValid=true;
            }
            else
            {
                throw new InvalidQuantityException("Quantity should be greater than zero");
            }
        }

        else
        {
            throw new InvalidFlavourException("Flavour not available. Please select the available flaour");
        }
        return isValid;
    }
    public double CalculatePrice()
    {
        int discount=0;
        switch (Flavour)
        {
            case "Vanilla":
            {
                 discount=3;
                 break;   
            }
            case "Red Velvet":
            {
                 discount=10;
                 break;   
            }
            case "Chocolate":
            {
                 discount=5;
                 break;   
            }
        }

        double totalPrice=QuantityInKg * PricePerKg;
        double discountedPrice = totalPrice - (totalPrice * discount /100);
        return discountedPrice;
    }

}


