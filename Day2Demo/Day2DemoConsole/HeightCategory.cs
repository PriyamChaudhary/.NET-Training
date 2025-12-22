using System;

namespace Day2DemoConsole;

public class HeightCategory
{
//Accept height in cm. If < 150 (Dwarf), 150-165 (Average), 165-190 (Tall), >190 (Abnormal).
public static void HeightMain(){
int height=Int32.Parse(Console.ReadLine());
if(height<150){
    System.Console.WriteLine("Dwarf");
}
else if(height>=150 && height<=165)
        {
            System.Console.WriteLine("Average");
        }
else if(height>165 && height<=190)
        {
            System.Console.WriteLine("Tall");
        }
else
        {
         System.Console.WriteLine("Abnormal");   
        }
}
}
