using System;

namespace Q10CommandPatternMiniFramework
{
    class Program
    {
        static void Main()
        {
            Commands comObj = new Commands();

            ICommand addItem = new AddCommand(comObj, "Laptop", 50000);
            ICommand applyDiscount = new DiscountCommand(comObj, 2000);

            addItem.Execute();
            applyDiscount.Execute();

            Console.WriteLine("Undo Discount");
            applyDiscount.Undo();

            Console.WriteLine("Undo Add Item");
            addItem.Undo();
        }
    }
}
