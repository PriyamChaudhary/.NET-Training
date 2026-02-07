using System;
using System.Collections.Generic;

namespace Q10CommandPatternMiniFramework;

public class Commands
{
    public List<string> products=new List<string>();
    public int Total{get; private set;}

    public void AddItem(string item, int price)
    {
        products.Add(item);
        Total = Total+price;

        Console.WriteLine($"Item Added Successfully: Name - {item} & Total - {Total}");
        
    }
    public void RemoveItem(string item, int price)
    {
        products.Add(item);
        Total = Total-price;

        Console.WriteLine($"Item Removed Successfully: Name - {item} & Total - {Total}");
        
    }
    public void ApplyDiscount(int discount)
    {
        Total=Total-discount;
        Console.WriteLine($"Rupees {discount} discount applied: Dicounted Price - {Total} ");
    }

}





