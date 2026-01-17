using System;
using System.Collections.Generic;
using System.Linq;

class Program{
public static SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>();

public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of items:");
        int numberOfItems = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numberOfItems; i++)
        {
            Console.WriteLine("Item name:");
            string itemName = Console.ReadLine();

            Console.WriteLine("Sold count:");
            long soldCount = Convert.ToInt64(Console.ReadLine());

            if (!itemDetails.ContainsKey(itemName))
            {
                itemDetails.Add(itemName, soldCount);
            }
        }

        Program itemObj = new Program();

        Console.WriteLine("Enter sold count for search: ");
        long searchCount = Convert.ToInt64(Console.ReadLine());

        SortedDictionary<string, long> foundItem = itemObj.FindItemDetails(searchCount);
        if (foundItem.Count == 0)
        {
            System.Console.WriteLine("Invalid item");
        }
        else
        {
            foreach(var item in foundItem)
            {
                System.Console.WriteLine($"{item.Key} : {item.Value}");
            }
        
            List<string> list = itemObj.FindMinandMaxSoldItems();
            System.Console.WriteLine($" Max: {list[0]} and Min: {list[1]}");

            Dictionary<string, long> sortedItem = itemObj.SortByCount();
            foreach(var item in sortedItem)
                {
                    System.Console.WriteLine($"{item.Key} : {item.Value}");
                }
        }
    }

public SortedDictionary<string, long> FindItemDetails(long soldCount)
{       
	SortedDictionary<string, long> availableDict=new SortedDictionary<string, long>();
	foreach(var item in itemDetails)
	{
	    if(item.Value==soldCount)
        {
            availableDict.Add(item.Key, item.Value);
        }
	    
	}
	return availableDict;
}

public List<string> FindMinandMaxSoldItems()
{
    List<string> minAndMax = new List<string>();
    long maxSold=0;
    long minSold=long.MaxValue;

    foreach(var item in itemDetails)
    {
       if(item.Value > maxSold)
       {
	      maxSold=item.Value;
       }
	   if(item.Value<minSold)
       {  
          minSold=item.Value;
       }
    }

	minAndMax.Add(maxSold.ToString());
    minAndMax.Add(minSold.ToString());

    return minAndMax;
    
}

public Dictionary<string, long> SortByCount()
{
    return itemDetails.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
}


}