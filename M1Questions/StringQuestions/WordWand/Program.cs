using System;
namespace WordWand;

public class SentenceProcessor
{
    private string input;
    public SentenceProcessor(string input)
    {
        this.input=input;
    }
    public bool IsValid()
    {
        foreach(char ch in input)
        {
            if(!char.IsLetter(ch) && ch!=' ')
            {
                return false;
            }

        }
        return true;
    }

    public void Process()
    {
        string[] str=input.Split(' ');
        int wordCount=0;
        foreach(string word in str)
        {
            if (word != "")
            {
                wordCount++;
            }
        }
        Console.WriteLine($"WordCount: {wordCount}");
        if (wordCount % 2 == 0)
        {
            for(int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] != "")
                {
                    Console.Write(str[i]+" ");
                }
            }
        }
        else
        {
            foreach(string word in str)
            {
                if (word != "")
                {
                    char[] w=word.ToCharArray();
                    Array.Reverse(w);
                    Console.Write(new string(w)+" ");
                }
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string input=Console.ReadLine();
        SentenceProcessor sObj=new SentenceProcessor(input);
        if (!sObj.IsValid())
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            sObj.Process();
        }
    }
}