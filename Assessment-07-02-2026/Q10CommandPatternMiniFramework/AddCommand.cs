using System;

namespace Q10CommandPatternMiniFramework;

public class AddCommand:ICommand
{
        private readonly Commands Command;
        private readonly string Item;
        private readonly int Price;

        public AddCommand(Commands command, string item, int price)
        {
            Command = command;
            Item = item;
            Price = price;
        }

        public void Execute()
        {
            Command.AddItem(Item, Price);
        }

        public void Undo()
        {
            Command.RemoveItem(Item, Price);
        }

}




