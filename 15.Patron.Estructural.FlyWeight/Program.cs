using System;
using _15.Patron.Estructural.FlyWeight.Ejemplo;
using RefactoringGuru.DesignPatterns.Flyweight.Conceptual;

namespace _15.Patron.Estructural.FlyWeight
{
    class Program
    {
        
        static void Main(string[] args)
        {
            EjecutarEjemplo();
            EjecutarConepto();
        }

        private static void EjecutarConepto()
        {
            // The client code usually creates a bunch of pre-populated
            // flyweights in the initialization stage of the application.
            var factory = new FlyweightFactory(
                new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
                new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
                new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
                new Car { Company = "BMW", Model = "M5", Color = "red" },
                new Car { Company = "BMW", Model = "X6", Color = "white" }
            );
            factory.listFlyweights();

            FlyweightHelper.addCarToPoliceDatabase(factory, new Car {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "M5",
                Color = "red"
            });

            FlyweightHelper.addCarToPoliceDatabase(factory, new Car {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "X1",
                Color = "red"
            });

            factory.listFlyweights();
        }

        private static void EjecutarEjemplo()
        {
            var factory = new Factory();
            for (int i = 0; i < 10; i++)
            {
                IPlayer p = factory.GetPlayer(EjemploCliente.GetPlayerRandom());
                p.AssignWeapon(EjemploCliente.GetWeaponRandom());
                p.Mission();
            }

            Console.WriteLine($"{factory.GetNumberOfInstances()}");
        }
    }
}
