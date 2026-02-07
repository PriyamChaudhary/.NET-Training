using System;


namespace XamXpertOnlineExam;

public interface IExam
{
    public double calculateScore();
    public static string evaluateResult(double percentage)
    {
        if (percentage >= 85)
        {
            return "Merit";
        }
        else if(percentage>=60 && percentage < 85)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }

}
