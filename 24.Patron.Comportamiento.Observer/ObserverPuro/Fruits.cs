using System.Collections.Generic;

namespace _24.Patron.Comportamiento.Observer.ObserverPuro
{
    public abstract class Fruits
    {
        private double _pricePerKg;
        private List<IRestaurant> _restaurants = new List<IRestaurant>();

        public Fruits(double pricePerKg)
        {
            _pricePerKg = pricePerKg;
        }

        public void Attach(IRestaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }
        public void Detach(IRestaurant restaurant)
        {
            _restaurants.Remove(restaurant);
        }
        public void Notify()
        {
            foreach (var restaurant in _restaurants)
            {
                restaurant.Update(this);
            }
        }
        public double PricePerKg
        {
            get { return _pricePerKg; }
            set 
            { 
                _pricePerKg = value;
                Notify();
            }
        }
    }
}