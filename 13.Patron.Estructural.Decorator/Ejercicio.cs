using System;

namespace _13.Patron.Estructural.Decorator.Ejercicio
{
   public interface IOrder
   {
        double GetCost();
   }

    public abstract class OrderDecorator : IOrder
    {
        private IOrder _order;
        protected double _cost = 0.0;
        protected OrderDecorator(IOrder order)
        {
            _order = order;
        }

        public double GetCost()
        {
            return _order.GetCost() + _cost;
        }
    }

    public class PremiumOrder : OrderDecorator
    {
        public PremiumOrder(IOrder order) : base(order)
        {
            _cost = 10;
        }
    }


    public class SimpleOrder : IOrder
    {
        public double GetCost()
        {
            return 15;
        }
    }

}
