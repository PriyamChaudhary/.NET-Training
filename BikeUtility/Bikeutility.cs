using System;
using System.Collections.Generic;
using System.Linq;

namespace BikeUtility;

public class Bikeutility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay) //public bool AddBikeDetails(Bike bObj)
    {
        Bike bikeObj=new Bike(model,brand,pricePerDay);
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        return new SortedDictionary<string, List<Bike>>(
            Program.bikeDetails.Values
            .GroupBy(b=>b.Brand)
            .ToDictionary(g=>g.Key, g=>g.ToList())

        );
        
    }
}