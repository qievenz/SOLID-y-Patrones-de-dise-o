using System;
using System.Collections.Generic;
using System.Linq;

namespace _18.Patron.Comportamiento.Command.Ejemplo
{
    public class Product
    {
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public int Price { get; set; }

        public void IncreasePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"El precio subio a {Price}");
        }

        public void DecreasePrice(int amount)
        {
            Price -= amount;
            Console.WriteLine($"El precio bajo a {Price}");
        }

        public override string ToString() => $"El precio actual de {Name} es {Price}";
    }

    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public enum PriceAction
    {
        Increase,
        Decrease
    }

    public class ProdcuctCommand : ICommand
    {
        private Product _product;
        private PriceAction _priceAction;
        private int _amount;
        public bool IsCommandExecuted {get; private set; }

        public ProdcuctCommand(Product product, PriceAction priceActionType, int amount)
        {
            _product = product;
            _priceAction = priceActionType;
            _amount = amount;
        }

        public void Execute()
        {
            switch (_priceAction)
            {
                case PriceAction.Increase:
                    _product.IncreasePrice(_amount);
                    break;
                case PriceAction.Decrease:
                    _product.DecreasePrice(_amount);
                    break;
                default:
                    break;
            }

            IsCommandExecuted = true;
        }

        public void Undo()
        {
            if (!IsCommandExecuted)
                return;

            switch (_priceAction)
            {
                case PriceAction.Increase:
                    _product.DecreasePrice(_amount);
                    break;
                case PriceAction.Decrease:
                    _product.IncreasePrice(_amount);
                    break;
                default:
                    break;
            }
        }
    }

    public class ModifyPrice
    {
        private List<ICommand> _commands;
        private ICommand _command;

        public ModifyPrice()
        {
            _commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command) => _command = command;

        public void Invoke()
        {
            _commands.Add(_command);
            _command.Execute();
        }

        public void Undo()
        {
            foreach (var command in Enumerable.Reverse(_commands))
            {
                command.Undo();
            }
        }
    }
}
