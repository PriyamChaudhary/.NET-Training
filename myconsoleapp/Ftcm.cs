public class Ftcm
{
    public static void FeetToCm()
    {
        double.TryParse(Console.ReadLine(),out double feet);
        double cm=feet*30.48;
        Console.WriteLine(cm);

    }
}