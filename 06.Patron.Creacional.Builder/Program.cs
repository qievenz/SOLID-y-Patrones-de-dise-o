using System;

namespace _06.Patron.Creacional.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new SandwichAssembly(new CheeseBurger());
            sandwich.Assemble();

            var a = sandwich.GetSandwich;
            Console.WriteLine(a);
                
        }
    }
}
