using System;
using System.Collections.Generic;

namespace DigitalPettyCashApp;

public class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("==========================Digital Petty Cash Ledger App===========================");
     
        var incomeLedger = new Ledger<IncomeTransaction>();
        incomeLedger.AddEntry(new IncomeTransaction(101, new DateTime(2026, 1, 7), 500, "Replenishment", "Main Cash"));

        var expenseLedger = new Ledger<ExpenseTransaction>();
        expenseLedger.AddEntry(new ExpenseTransaction(203, new DateTime(2026, 1, 7), 20, "Stationery", "Office"));
        expenseLedger.AddEntry(new ExpenseTransaction(105, new DateTime(2026, 1, 7), 15, "Team Snacks", "Food"));

        int totalIncome = incomeLedger.CalculateTotal();
        int totalExpenses = expenseLedger.CalculateTotal();
        int netBalance = totalIncome - totalExpenses;

        Console.WriteLine("==== Total =====");
        Console.WriteLine($"Total Income:   {totalIncome}");
        Console.WriteLine($"Total Expenses: {totalExpenses}");
        Console.WriteLine($"Net Balance:    {netBalance}");
        Console.WriteLine();

        var allTransactions = new List<Transaction>();
        allTransactions.AddRange(incomeLedger.Entries);
        allTransactions.AddRange(expenseLedger.Entries);

        Console.WriteLine("=======Transaction Summaries=======");
        foreach (var t in allTransactions)
        {
            Console.WriteLine(t.GetSummary());
        }
    }
}






































































