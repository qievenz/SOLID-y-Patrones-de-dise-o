using System;

namespace _04.SOLID.InterfaceSegregation
{
    public interface IMotorVehicle : IVehicle
    {
        int startEngine();
        int stopEngine();  
    }

    public class Auto : IMotorVehicle
    {
        public int GetNumberOfWheel()
        {
            int ruedas = 4;

            Console.WriteLine($"Ruedas: {ruedas}");

            return ruedas;
        }

        public void Move()
        {
            Console.WriteLine("Moviendo auto");            
        }

        public int startEngine()
        {
            Console.WriteLine("Arrancando auto");

            return 0;
        }

        public int stopEngine()
        {
            throw new System.NotImplementedException();
        }
    }
}

