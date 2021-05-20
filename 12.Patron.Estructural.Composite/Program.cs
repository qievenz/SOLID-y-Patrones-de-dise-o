using System;
using System.Collections.Generic;
using System.Linq;
using _12.Patron.Estructural.Composite.Ejemplo;
using _12.Patron.Estructural.Composite.Ejercicio;

namespace _12.Patron.Estructural.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            EjemploProductos();
            var ramiro = new TeamMember("ramiro", 1300);
            var carlos = new TeamMember("carlos", 3600);
            var pedro = new TeamMember("pedro", 2700);
            var sebastian = new TeamMember("sebastian", 1800);

            var lider = new TeamLead("El lider");
            lider.Add(ramiro);
            lider.Add(carlos);
            lider.Add(pedro);
            lider.Add(sebastian);

            Console.WriteLine($"{lider.GetCost()}");
        }

        private static void EjemploProductos()
        {
            var ram = new SimpleProduct("Ram 1", 1300);
            var cpu = new SimpleProduct("CPU 1", 3600);
            var ram2 = new SimpleProduct("Ram 2", 2700);
            var card = new SimpleProduct("Card 1", 1800);

            var gamingKit = new CompositeProduct("Gamer PC");
            gamingKit.Add(ram);
            gamingKit.Add(cpu);
            gamingKit.Add(ram2);
            gamingKit.Add(card);

            Console.WriteLine($"{gamingKit.GetPrice()}");
        }
    }
}
