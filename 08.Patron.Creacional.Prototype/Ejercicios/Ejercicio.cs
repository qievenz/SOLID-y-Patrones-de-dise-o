using System;

namespace _08.Patron.Creacional.Prototype.Ejercicio
{
 public class Product
    {
        public string Name { get; set; }
        public Price  Price { get; set; }
        public Product DeepCopy()
         {
             return new Product { Name = Name, Price = new Price(Price) };
         }
    }

    public class Price
    {
        public double Amount { get; set; }
        public Price() { }
        public Price(Price price)
        {
            Amount = price.Amount;
        }
    }
}