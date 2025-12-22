using DemoDay3;
using System.Dynamic;

internal class Program
{
static void SwapMe(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine("Inside swap funct\nvalue for num1: {0} num2: {1}",x,y);
    }
public int AddToCart(params int[] prices)
    {
        int total;
        foreach (int i in prices)
        {
            total += i;
        }
        return total;
    }
public int AddToCart(int p1, int p2)
    {

    }
public int AddToCart(int p1, int p2,int p3)
    {

    }
    public static void Main()
    {
        int x = 100, y = 200;
        SwapMe(ref x, ref y);

        Program pObj = new Program();
        pObj.AddToCart(10, 20);
        pObj.AddToCart(10, 20, 30, 40, 50);

        
    }
}