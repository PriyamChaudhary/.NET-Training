using System;

namespace Q10CommandPatternMiniFramework;

public class DiscountCommand:ICommand
{
        private readonly Commands Command;
        private readonly int Discount;

        public DiscountCommand(Commands command, int discount)
        {
            Command = command;
            Discount=discount;
           
        }

        public void Execute()
        {
            Command.ApplyDiscount(Discount);
        }

        public void Undo()
        {
            int d=-Discount;
            Command.ApplyDiscount(d);
        }

}

