using System;

namespace _23.Patron.Comportamiento.NullObject.Ejemplo
{
    public interface IDiscount
    {
        double CalculateDiscount(double price);

    }
    public class StudentDiscount : IDiscount
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.5;
        }
    }
    public class FriendDiscount : IDiscount
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.6;
        }
    }
    public class NullDiscount : IDiscount
    {
        public double CalculateDiscount(double price)
        {
            return 0;
        }
    }

    public class Order
    {
        private IDiscount _discount;
        private double _price;

        public Order()
        {
        }

        public Order(IDiscount discount, double price)
        {
            _discount = discount;
            _price = price;
        }

        public double GetDiscount() => _discount.CalculateDiscount(_price);

        public Order GetOrderByProductName(string product) => new Order();
    }
}
