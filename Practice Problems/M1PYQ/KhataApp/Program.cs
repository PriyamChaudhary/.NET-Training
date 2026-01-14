using System;
using System.Collections.Generic;

namespace KhataApp;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> record = new Dictionary<string, int>()
        {
            {"Milk", 100},
            {"Tea", 50},
            {"Coffee", 100},
            {"Sugar", 50},
            {"Salt", 200}
        };
        Khata khata = new Khata(record);
        Console.WriteLine("Total Amount: " + khata.getTotal());
        Console.WriteLine("Number of Repeated Amounts: " + khata.getRepeatAmount());

        
    }
}

