using System;

namespace _06.Patron.Creacional.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new Builder.SandwichAssembly(new Builder.CheeseBurger());
            sandwich.Assemble();

            var a = sandwich.GetSandwich;
            Console.WriteLine(a);
            
            var sandwichFluent = new FluentBuilder.SandwichBuilder()
                .WithCheeseChedar()
                .WithMayoMustard();
        }
    }
}
