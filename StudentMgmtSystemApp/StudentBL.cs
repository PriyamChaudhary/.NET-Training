using System;

namespace StudentMgmtSystemApp;

public class StudentBL
{
    Student sObj=null;

    public StudentBL()
    {
     sObj=new Student();   
    }
    public void AcceptStudentDetails()
    {
        try{
        Console.ForegroundColor=ConsoleColor.DarkMagenta;
        System.Console.WriteLine("Student Management System ");
        System.Console.WriteLine("==============================================");
        Console.ForegroundColor=ConsoleColor.Green;

        System.Console.WriteLine("Enter your roll no: ");
        sObj.RollNo=Int32.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter your Name: ");
        sObj.Name=Console.ReadLine();

        System.Console.WriteLine("Enter your Address: ");
        sObj.Address=Console.ReadLine();

        Console.ForegroundColor=ConsoleColor.White;
        System.Console.WriteLine("Enter your Physics marks: ");
        sObj.Phy=Int32.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter your Chemistry marks: ");
        sObj.Chem=Int32.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter your Maths marks: ");
        sObj.Maths=Int32.Parse(Console.ReadLine());

    }
    catch(InvalidMarksException e)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            System.Console.WriteLine(e.Message);
        }
    catch(Exception e)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            System.Console.WriteLine(e.Message);
        }
    }
     
    public int CalcTotal()
    {
        sObj.Total=sObj.Phy + sObj.Chem + sObj.Maths;
        return sObj.Total;
    }
    public float CalcAvg()
    {
        sObj.Perc=sObj.Total/3;
        return sObj.Perc;
    }
    public void CalcResult(out int myTotal, out float myPerc)
    {
        myTotal=sObj.Phy + sObj.Chem + sObj.Maths;
        myPerc=myTotal/3;
        
    }
}
