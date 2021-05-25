using System;
using _22.Patron.Comportamiento.Mediator.Concepto;
using _22.Patron.Comportamiento.Mediator.Ejemplo;

namespace _22.Patron.Comportamiento.Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            EjecutarConcepto();
            EjecutarEjemplo();
        }

        public static void EjecutarConcepto()
        {
            // The client code.
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggets operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
        }

        private static void EjecutarEjemplo()
        {
            var med = new AirTrafficControlMediator();
            var vuelo = new Flight(med);
            var pista = new Runway(med);

            med.RegisterFlihgt(vuelo);
            med.RegisterRunway(pista);

            vuelo.Land();
            pista.Land();
            vuelo.Land();
        }
    }
}
