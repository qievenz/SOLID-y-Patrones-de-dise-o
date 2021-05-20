using System;
using _13.Patron.Estructural.Decorator.Concepto;
using _13.Patron.Estructural.Decorator.Ejemplo;

namespace _13.Patron.Estructural.Decorator
{

    class Program
    {
        static void Main(string[] args)
        {
            Ejemplo();
        }

        public static void Ejemplo()
        {
            var espressoWithMilkAndChocolate = new MilkDecorator(new ChocolateDecorator(new Espresso()));
            Console.WriteLine($"El precio de {espressoWithMilkAndChocolate.GetDescription()} {espressoWithMilkAndChocolate.GetCost().ToString("N2")}");
            Console.ReadLine();
        }

        public static void Concepto()
        {
            Client client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);
        }
    }
}
