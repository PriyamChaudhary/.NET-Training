using System;

namespace XamXpertOnlineExam;

public class OnlineTest:IExam
{
    public string StudentName{get; set;}
    public int TotalQuestions{get; set;}
    public int CorrectAnswers{get; set;}
    public int WrongAnswers{get; set;}
    public string QuestionType{get; set;}

    public OnlineTest(string name, int totalQuestions,int correctAnswers,int wrongAnswers,string questionType)
    {
        StudentName=name;
        TotalQuestions=totalQuestions;
        CorrectAnswers=correctAnswers;
        WrongAnswers=wrongAnswers;
        QuestionType=questionType;
    }

    public double calculateScore()
    {
        int marksPerQuestion=0;
        if (QuestionType.Trim().Equals("MCQ", StringComparison.OrdinalIgnoreCase))
        {
            marksPerQuestion = 2;
        }

        else if (QuestionType.Trim().Equals("Coding", StringComparison.OrdinalIgnoreCase))
        {
            marksPerQuestion = 5;
        }
        double totalScore=(CorrectAnswers*marksPerQuestion)-(WrongAnswers*marksPerQuestion*0.10);
        double percentage=(totalScore/(TotalQuestions*marksPerQuestion))*100;
        return percentage;
    }

}
