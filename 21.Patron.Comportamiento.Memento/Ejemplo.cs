using System;
using System.Collections.Generic;

namespace _21.Patron.Comportamiento.Memento.Ejemplo
{
    public class Memento
    {
        public int Balance { get;  }
        public Memento(int balance)
        {
            Balance = balance;
        }
    }

    public class Account
    {
        public Account(int balance)
        {
            Balance = balance;
            _operations.Add(new Memento(balance));
        }
        public Memento Deposit(int amount)
        {
            Balance += amount;
            
            var memento = new Memento(Balance);
            
            _operations.Add(memento);
            _current++;
            
            return memento;
        }

        public Memento Undo()
        {
            if(_current > 0)
            {
                var memento = _operations[_current--];
                Balance = memento.Balance;

                return memento;
            }

            return null;
        }

        public Memento Redo()
        {
            if (_current < _operations.Count)
            {
                var memento = _operations[_current++];
                Balance = memento.Balance;

                return memento;
            }

            return null;
        }

        public int Balance { get; set; }

        private List<Memento> _operations = new List<Memento>();
        private int _current;

        public override string ToString()
        {
            return $"Balance: {Balance}";
        }

        public void Restore(Memento memento)
        {
            Balance = memento.Balance;
        }
    }
}