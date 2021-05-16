namespace _06.Patron.Creacional.Builder.Ejercicio
{
    public sealed class Car
    {
        public string Name;
        public string Model;

    }
    
    public class CarBuilder
    {
        protected Car _car;
        
        public Car Build()
        {
            return _car;
        }

        private CarBuilder()
        {
            _car = new Car();
        }

        public static CarBuilder CreateNew()
        {
            return new CarBuilder();
        }


        public CarBuilder AddName(string name)
        {
            _car.Name = name;
            
            return this;
        }

        public CarBuilder AddModel(string model)
        {
            _car.Model = model;

            return this;
        }
    }
}