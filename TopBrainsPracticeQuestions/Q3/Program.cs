using System;

class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int upto = Convert.ToInt32(Console.ReadLine());
        int[] row = new int[upto];
        for(int i = 0; i < upto; i++)
        {
            row[i]=n*(i+1);
        }
        System.Console.Write("[");
        for(int i = 0; i < upto; i++)
        {
            System.Console.Write(row[i]+",");
        }
        System.Console.WriteLine("]");
    }
}