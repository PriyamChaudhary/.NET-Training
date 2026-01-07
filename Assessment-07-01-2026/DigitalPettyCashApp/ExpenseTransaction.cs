using System;

namespace DigitalPettyCashApp;

public class ExpenseTransaction : Transaction
{
    public string Category { get; set; }

    public ExpenseTransaction(int id, DateTime date, int amount, string description, string category): base(id, date, amount, description)
    {
        Category = category;
    }

    public override string GetSummary()
    {
        return $"Expense Id:{Id}, Date:{Date}, Category:{Category}, Description:{Description}, Amount:${Amount}";
    }

}



















































