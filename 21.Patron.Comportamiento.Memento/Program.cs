using System;
using System.Collections.Generic;
using _21.Patron.Comportamiento.Memento.Ejemplo;
using _21.Patron.Comportamiento.Memento.Concepto;

namespace _21.Patron.Comportamiento.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            EjecutarEjemplo();
        }

        private static void EjecutarConcepto()
        {
            // Client code.
            Originator originator = new Originator("Super-duper-super-puper-super.");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.Undo();

            Console.WriteLine();
        }

        private static void EjecutarEjemplo()
        {
            var account = new Account(300);
            var m1 = account.Deposit(20);
            var m2 = account.Deposit(40);
            Console.WriteLine($"{account.ToString()}");
            account.Restore(m1);
            Console.WriteLine($"{account.ToString()}");
            var m3 = account.Deposit(40);
            Console.WriteLine($"{account.ToString()}");
            account.Undo();
            Console.WriteLine($"{account.ToString()}");
        }
    }
}
