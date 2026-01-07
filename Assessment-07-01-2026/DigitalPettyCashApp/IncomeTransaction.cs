using System;

namespace DigitalPettyCashApp;

class IncomeTransaction : Transaction
{
    public string Source { get; set; }

    public IncomeTransaction(int id, DateTime date, int amount, string description, string source): base(id, date, amount, description)
    {
        Source = source;
    }

    public override string GetSummary()
    {
        return $"Income Id:{Id}, Date:{Date}, Source:{Source}, Description:{Description}, Amount:${Amount}";
    }


}
