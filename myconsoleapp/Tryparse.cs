public class Tryparse
{
    public static void Main()
    {
        Console.Write("Enter age: ");
        string? input = Console.ReadLine();
        if(int.TryParse(input, out int age))
        {
            bool isAdult=age>=18;
            Console.WriteLine("adult? "+isAdult);
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}