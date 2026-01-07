using System;
using System.Collections.Generic;

namespace DigitalPettyCashApp;

public class Ledger<T> where T : Transaction
{
    List<T> recordList = new List<T>();

    public void AddEntry(T entry){
        recordList.Add(entry);
    }

    public List<T> GetTransactionsByDate(DateTime date){
        List<T> transactionByDateList = new List<T>();
       
        foreach(var i in transactionByDateList){
            if(i.Date.Date==date.Date){
                transactionByDateList.Add(i);
            }
        }
        return transactionByDateList;
    }

    public int CalculateTotal(){
        int totalAmount=0;

        foreach(var i in recordList){
            totalAmount+=i.Amount;
        }
        return totalAmount;
    }
    public List<T> Entries => recordList;
}
























































































