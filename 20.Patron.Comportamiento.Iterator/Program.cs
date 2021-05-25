using System;
using _20.Patron.Comportamiento.Iterator.Ejemplo;
using RefactoringGuru.DesignPatterns.Iterator.Conceptual;

namespace _20.Patron.Comportamiento.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            EjecutarConcepto();
            EjecutarEjemplo();
        }

        private static void EjecutarConcepto()
        {
            // The client code may or may not know about the Concrete Iterator
            // or Collection classes, depending on the level of indirection you
            // want to keep in your program.
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }

        private static void EjecutarEjemplo()
        {
            var breakfastMenu = new BreakfastMenuCollection();
            var dinnerMenu = new DinnerMenuCollection();

            IIterator<Menu> breakfastIterator = breakfastMenu.CreateIterator();
            IIterator<Menu> dinnerIterator = dinnerMenu.CreateIterator();

            Iterate(breakfastIterator);
            Iterate(dinnerIterator);
        }

        private static void Iterate(IIterator<Menu> iterator)
        {
            while(iterator.HasNext())
            {
                var menu = iterator.Next();
                Console.WriteLine(menu.Name);
                Console.WriteLine(menu.Description);
                Console.WriteLine(menu.Price);
            }
        }
    }
}
