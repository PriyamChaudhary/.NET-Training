using System;
using System.Collections;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        //Generic
        List<int> numbers = new List<int>();
        numbers.Add(2);
        numbers.Add(6);

        // Non Generic
        ArrayList arr = new ArrayList();
        arr.Add(1);
        arr.Add(8);

        //string reverse 
        string str ="Priyam";
        
        for(int i = str.Length-1; i >=0; i--)
        {
            Console.Write($"{str[i]}");
        }
        Console.WriteLine();


        //frequency of characters
        Dictionary<char, int> freq=new Dictionary<char, int>();

        foreach(var ch in str)
        {
            if (freq.ContainsKey(ch))
            {
                freq[ch]++;
            }
            else
            {
                freq[ch]=1;
            }
        }
        foreach(var i in freq)
        {
            Console.WriteLine($"{i.Key} : {i.Value}");
        }


//deletion count
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        int del = 0;

        foreach (char i in word1)
        {
            bool isCommon = false;

            foreach (char j in word2)
            {
                if (i == j)
                {
                    isCommon = true;
                    break;
                }
            }

            if (!isCommon)
            {
                del++;
            }
        }

        Console.WriteLine(del);
    }
}

 
        
        
    

