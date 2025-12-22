public class Test
{
    public static void Run()//functions of variables with static keywords never get deleted from memory and garbage collector cannot touch it
    {
        // Console.WriteLine("Hello from Test.cs");
        // Console.WriteLine("Enter your name: ");
        // string? name = Console.ReadLine();
        // Console.WriteLine("Hello," + name + "!");
       int a = 19;
       bool prime=true;
       for(int i = 2; i <= Math.Sqrt(a); i++)
        {
            if (a % i == 0)
            {
                prime=false;
                break;
            }         
        }
        Console.WriteLine(prime);

    }
}
