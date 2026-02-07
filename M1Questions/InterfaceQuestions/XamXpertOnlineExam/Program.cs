using System;
namespace XamXpertOnlineExam;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Exam Details: ");

        Console.WriteLine("Student Name: ");
        string name=Console.ReadLine();

        Console.WriteLine("Question Type(MCQ/Coding): ");
        string questionType=Console.ReadLine();

        Console.WriteLine("Total Questions: ");
        int totalQuestions=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Correct Answers: ");
        int correctAnswers=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Wrong Answers: ");
        int wrongAnswers=Convert.ToInt32(Console.ReadLine());

        OnlineTest studentObj=new OnlineTest(name, totalQuestions, correctAnswers, wrongAnswers, questionType);

        double percentage=studentObj.calculateScore();
        string result=IExam.evaluateResult(percentage);

        Console.WriteLine("Exam Summary: ");
        Console.WriteLine($"{questionType} Test: {name}, Total Score: {percentage}, Result: {result}");



    }
}