using System;
using System.Collections.Generic;
using _17.Patron.Comportamiento.Chain.Concepto;
using _17.Patron.Comportamiento.Chain.Ejemplo;

namespace _17.Patron.Comportamiento.Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            EjecutarEjemplo();
            EjecutarConcepto();
        }

        private static void EjecutarConcepto()
        {
            // The other part of the client code constructs the actual chain.
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.
            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);
        }

        private static void EjecutarEjemplo()
        {
            var iphone = new Mobile("iphonew", MobileType.Premium, 900);
            var xiaome = new Mobile("xiamoi", MobileType.Medium, 300);
            var samsung = new Mobile("samsunfg", MobileType.Basic, 130);

            var phones = new List<Mobile>();
            phones.Add(iphone);
            phones.Add(xiaome);
            phones.Add(samsung);

            var employee = new Employee(new MobileBasic());
            var super = new Supervisor(new MobileMedium());
            var Ceo = new Ceo(new MobilePremium());

            employee.SetSuccessor(super);
            super.SetSuccessor(Ceo);
            phones.ForEach(t => employee.HandleRequest(t));
        }
    }
}
