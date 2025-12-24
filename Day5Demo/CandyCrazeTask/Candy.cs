using System;

namespace CandyCrazeTask;

public class Candy
{
    public string Flavour { get; set; }
    public int Quantity { get; set; }
    public int PricePerPiece { get; set; }
    public double TotalPrice { get; set; }
    public double Discount { get; set; }

    public bool ValidateCandyFlavour()
    {
        bool isValid = false;
        if(Flavour == "Lemon" || Flavour == "Strawberry" || Flavour == "Mint")
        {
            isValid = true;
        }
        return isValid;
    }
}
