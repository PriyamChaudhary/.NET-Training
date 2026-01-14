using System;

namespace KhataApp;

public class Khata
{
    public Dictionary<string, int> record=new Dictionary<string, int>();
    public Khata(Dictionary<string, int> record)
    {
        this.record = record;
    }

    public int getTotal()
    {
        int total=0;
        foreach(var item in record)
        {
            total+=item.Value;
        }
        return total;  
    }

    public int getRepeatAmount()
    {   
        Dictionary<int, int> freqDict = new Dictionary<int, int>();
        foreach (var item in record)
        {
            if (freqDict.ContainsKey(item.Value))
            {
                freqDict[item.Value]++;
            }
            else
            {
                freqDict[item.Value] = 1;
            }
        }
        
        int count = 0;
        foreach (var freq in freqDict)
        {
            if (freq.Value > 1)
            {
                count++;
            }
        }
        return count;
    }


}
