using System;

namespace _16.Patron.Estructural.Proxy.Ejemplo
{
    public interface ICar
    {
        void Drive();
    }

    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine($"conduciondo el auto");
        }
    }

    public class Driver
    {
        private int _age;
        private bool _hasLiense;

        public Driver(int age, bool hasLiense)
        {
            _age = age;
            _hasLiense = hasLiense;
        }

        internal bool CanDrive() => _age >= 18 && _hasLiense;
    }

    public class CarProxy : ICar
    {
        private Car _car = new Car();
        private Driver _driver;

        public CarProxy(Driver driver)
        {
            _driver = driver;
        }

        public void Drive()
        {
            if(_driver.CanDrive())
                _car.Drive();
            else
                Console.WriteLine($"No puede conducir");
                
        }
    }
}