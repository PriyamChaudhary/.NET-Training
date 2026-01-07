using System;

namespace DigitalPettyCashApp;

public abstract class Transaction
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Amount { get; set; }
    public string Description { get; set; }

    public Transaction(int id, DateTime date, int amount, string description)
    {
        Id = id;
        Date = date;
        Amount = amount;
        Description = description;

    }
    public abstract string GetSummary();

}
