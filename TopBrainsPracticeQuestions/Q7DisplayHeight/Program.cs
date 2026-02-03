namespace Q7DisplayHeight;

class Program
{
    static void Main()
    {
        int height=Convert.ToInt32(Console.ReadLine());
        string category = GetHeightCategory(height);
        Console.WriteLine(category);
    }

    static string GetHeightCategory(int height)
    {
        if (height < 150)
            return "Short";
        else if (height < 180)
            return "Average";
        else
            return "Tall";
    }
}
