using System;

namespace Assignment1;

public class Book
{
    string title;
    string author;
    int numPages;
    DateTime dueDate;
    DateTime returnedDate;
    public Book()
    {
        
    }
    public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
    {
        this.title=title;
        this.author=author;
        this.numPages=numPages;
        this.dueDate=dueDate;
        this.returnedDate=returnedDate;
    }
    public double AveragePagesReadPerDay(int daysToRead)
    {
        double averagePagesReadPerDay = numPages / daysToRead;
        return averagePagesReadPerDay;
    }
    public double CalculateLateFee(double dailyLateFeeRate)
    {
        int numberOfDaysLate = (returnedDate - dueDate).Days;
        double lateFee = numberOfDaysLate * dailyLateFeeRate;
        return lateFee;
    }
}
