using System;

namespace _24.Patron.Comportamiento.Observer.ObserverPuro
{
    public class Restaurant : IRestaurant
    {
        private string _name;
        private double _purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(Fruits fruits)
        {
            Console.WriteLine($"Notificando a {_name}, el precio de {fruits.GetType().Name} cambio a {fruits.PricePerKg}");

            if (fruits.PricePerKg < _purchaseThreshold)
            {
                Console.WriteLine($"{_name} quiere comprar {fruits.GetType().Name}");
            }
        }
    }
}