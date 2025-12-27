using System;

namespace QuickMartProfitCalculator;

public class SaleTransaction
{
    public string InvoiceNo { get; set; }
    public string CustomerName { get; set; }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public decimal PurchaseAmount { get; set; }
    public decimal SellingAmount { get; set; }
    public string ProfitOrLossStatus { get; set; } 
    public decimal ProfitOrLossAmount { get; set; }
    public decimal ProfitMarginPercent { get; set; }

    public static SaleTransaction LastTransaction;
    public static bool HasLastTransaction;

    public static void CreateNewTransaction()
    {
        Console.Write("Enter Invoice No: ");
        string? invoice = Console.ReadLine();
        if(invoice == null)
        {
            Console.WriteLine("Invoice cannot be null");
        }

        Console.Write("Enter Customer Name: ");
        string? customerName = Console.ReadLine();

        Console.Write("Enter Item Name: ");
        string? itemName = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
        {
            Console.WriteLine("Invalid Quantity. Quantity must be an integer greater than 0. Transaction aborted.");
            return;
        }

        Console.Write("Enter Purchase Amount (total): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal purchaseAmount) || purchaseAmount <= 0m)
        {
            Console.WriteLine("Invalid Purchase Amount. It must be greater than 0. Transaction aborted.");
            return;
        }

        Console.Write("Enter Selling Amount (total): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal sellingAmount) || sellingAmount < 0m)
        {
            Console.WriteLine("Invalid Selling Amount. It must be >= 0. Transaction aborted.");
            return;
        }

        var tax = new SaleTransaction
        {
            InvoiceNo = invoice,
            CustomerName = customerName ?? string.Empty,
            ItemName = itemName ?? string.Empty,
            Quantity = quantity,
            PurchaseAmount = purchaseAmount,
            SellingAmount = sellingAmount
        };

        tax.ComputeProfitLoss();

        LastTransaction = tax;
        HasLastTransaction = true;

        Console.WriteLine("Transaction saved successfully.");
        Console.WriteLine($"Status: {tax.ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {tax.ProfitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {tax.ProfitMarginPercent:F2}");
         Console.WriteLine("------------------------------------------------------");
    }

    public static void ViewLastTransaction()
    {
        if (!HasLastTransaction || LastTransaction == null)
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        var lastTrans = LastTransaction;
        Console.WriteLine("-------------- Last Transaction --------------");
        Console.WriteLine($"InvoiceNo: {lastTrans.InvoiceNo}");
            Console.WriteLine($"Customer: {lastTrans.CustomerName}");
            Console.WriteLine($"Item: {lastTrans.ItemName}");
            Console.WriteLine($"Quantity: {lastTrans.Quantity}");
            Console.WriteLine($"Purchase Amount: {lastTrans.PurchaseAmount:F2}");
            Console.WriteLine($"Selling Amount: {lastTrans.SellingAmount:F2}");
            Console.WriteLine($"Status: {lastTrans.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {lastTrans.ProfitOrLossAmount:F2}");
            Console.WriteLine($"Profit Margin (%): {lastTrans.ProfitMarginPercent:F2}");
            Console.WriteLine("--------------------------------------------");
        }

        public static void CalculateProfitLoss()
        {
            if (!HasLastTransaction || LastTransaction == null)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            LastTransaction.ComputeProfitLoss();

            Console.WriteLine("Recomputed transaction:");
            Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");
            Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
            Console.WriteLine("------------------------------------------------------");
        }

        private void ComputeProfitLoss()
        {
            if (SellingAmount > PurchaseAmount)
            {
                ProfitOrLossStatus = "PROFIT";
                ProfitOrLossAmount = SellingAmount - PurchaseAmount;
            }
            else if (SellingAmount < PurchaseAmount)
            {
                ProfitOrLossStatus = "LOSS";
                ProfitOrLossAmount = PurchaseAmount - SellingAmount;
            }
            else
            {
                ProfitOrLossStatus = "BREAK-EVEN";
                ProfitOrLossAmount = 0m;
            }

            ProfitMarginPercent = PurchaseAmount > 0 ? (ProfitOrLossAmount / PurchaseAmount) * 100m : 0m;
        }
    }
