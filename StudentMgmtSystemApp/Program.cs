// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using StudentMgmtSystemApp;

StudentBL sblObj=new StudentBL();
sblObj.AcceptStudentDetails();
// sblObj.CalcTotal();
// sblObj.CalcAvg();
int t1;//total
float p1;//percentage
sblObj.CalcResult(out t1,out p1);
// System.Console.WriteLine($"Total : {sblObj.CalcTotal()}");
// System.Console.WriteLine($"Percentage : {sblObj.CalcAvg()}");
System.Console.WriteLine($"Total : {t1}");
System.Console.WriteLine($"Percentage : {p1}");