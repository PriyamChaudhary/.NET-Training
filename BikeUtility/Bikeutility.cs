using System;
using System.Collections.Generic;
using System.Linq;

namespace BikeUtility;

public class Bikeutility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = Program.bikeDetails.Count + 1;

        Bike bikeObj = new Bike(brand, model, pricePerDay);
        Program.bikeDetails.Add(key, bikeObj);
        
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> groupedBikes = new SortedDictionary<string, List<Bike>>();
        
        foreach (var i in Program.bikeDetails.Values)
        {
            if (!groupedBikes.ContainsKey(i.Brand))
            {
                groupedBikes[i.Brand] = new List<Bike>();
            }
            groupedBikes[i.Brand].Add(i);
        }
        
        return groupedBikes;
    }
}