using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Patron.Estructural.Composite.Ejemplo
{
    public abstract class Product
    {
        protected Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; private set; }
        public int Price { get; private set; }

        public abstract void Add(Product product);
        public abstract void Remove(Product product);
        public abstract string GetPrice();
    }

    public class SimpleProduct : Product
    {
        public SimpleProduct(string name, int price) : base(name, price)
        {
        }

        public override void Add(Product product)
        {
            //No se puede porque es el que esta mas abajo de la jerarquia
            throw new NotImplementedException();
        }

        public override string GetPrice()
        {
            return $"El precio de {Name} es: {Price}.C2";
        }

        public override void Remove(Product product)
        {
            //No se puede porque es el que esta mas abajo de la jerarquia
            throw new NotImplementedException();
        }
    }
    public class CompositeProduct : Product
    {
        List<Product> _products = new List<Product>();

        public CompositeProduct(string name) : base(name, 0)
        {
        }

        public override void Add(Product product)
        {
            _products.Add(product);
        }

        public override string GetPrice()
        {
            return $"El precio de {Name} es: {_products.Sum(o => o.Price)}.C2";
        }

        public override void Remove(Product product)
        {
            _products.Remove(product);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var ram = new SimpleProduct("Ram 1", 1300);
            var cpu = new SimpleProduct("CPU 1", 3600);
            var ram2 = new SimpleProduct("Ram 2", 2700);
            var card = new SimpleProduct("Card 1", 1800);

            var gamingKit = new CompositeProduct("Gamer PC");
            gamingKit.Add(ram);
            gamingKit.Add(cpu);
            gamingKit.Add(ram2);
            gamingKit.Add(card);

            Console.WriteLine($"{gamingKit.GetPrice()}");
            
        }
    }
}
