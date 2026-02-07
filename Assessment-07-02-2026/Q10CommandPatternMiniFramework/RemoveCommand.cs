using System;

namespace Q10CommandPatternMiniFramework;

public class RemoveCommand:ICommand
{
        private readonly Commands Command;
        private readonly string Item;
        private readonly int Price;

        public RemoveCommand(Commands command, string item, int price)
        {
            Command = command;
            Item = item;
            Price = price;
        }

        public void Execute()
        {
             Command.RemoveItem(Item, Price);
        }

        public void Undo()
        {
            Command.AddItem(Item, Price);
        }

}

