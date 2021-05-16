using System;

namespace _04.SOLID.InterfaceSegregation
{
    public class Bicicleta : INoMotorVehicle
    {
        public void changeChain()
        {
            Console.WriteLine("Cambiando cadena");
        }

        public int GetNumberOfWheel()
        {
            var ruedas = 2;
            
            Console.WriteLine($"Ruedas en la bicicleta: {ruedas}");
            
            return ruedas;
        }

        public void Move()
        {
            Console.WriteLine("Moviendo bicicleta");
            
        }
    }
}

