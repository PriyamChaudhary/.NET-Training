// See https://aka.ms/new-console-template for more information
using Day2DemoConsole;
// static void Menu()
// {
//     System.Console.WriteLine("1. Add");
//     System.Console.WriteLine("2. Sub");
//     System.Console.WriteLine("3. Drop");
// }

Console.WriteLine("Hello, World!");

Student sObj=new Student(123,"Priyam","Kota");

sObj.DisplayDetails(sObj);

sObj=new Student(123,"Priyam","Varanasi");

sObj.DisplayDetails(sObj);

string[] cities={"Pune","Chennai","Agra","Amritsar","Mumbai"};
foreach(var item in cities)
{
    System.Console.WriteLine(item);
}
// int choice=0;
// switch (choice)
// {
//     case 1:
//         {
//            break; 
//         }
//     case 2:
//         {
//            break; 
//         } 
    
// }
HeightCategory.HeightMain();
