using System;

namespace Coding.Exercise
{
   public class Memento
    {
        public int Price { get;  }
        public Memento(int price)
        {
            Price = price;
        }
    }

    public class Product
    {
        public int Price { get; set; }

        public Product(int price)
        {
            Price = price;
        }

        public Memento ChangePrice(int price)
        {
            Price += price;
            return new Memento(Price);
        }

        public void Restore(Memento memento)
        {
            Price = memento.Price;
        }
    }
    
}
