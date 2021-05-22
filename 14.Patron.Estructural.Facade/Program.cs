using System;
using _14.Patron.Estructural.Facade.Concepto;
using _14.Patron.Estructural.Facade.Ejemplo;

namespace _14.Patron.Estructural.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            EjecutarEjemplo();
            EjecutarConcepto();
        }

        private static void EjecutarEjemplo()
        {
            var homeController = new HomeController();

            Console.WriteLine($"Llegando a casa");
            homeController.TurnOn();
            Console.WriteLine($"Saliendo de casa");
            homeController.TurnOff();
        }

        private static void EjecutarConcepto()
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            FacadeClass facade = new FacadeClass(subsystem1, subsystem2);
            Client.ClientCode(facade);
        }
    }
}
