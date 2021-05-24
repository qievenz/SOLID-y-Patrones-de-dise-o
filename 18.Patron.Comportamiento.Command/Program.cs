using System;
using System.Collections.Generic;
using System.Linq;
using _18.Patron.Comportamiento.Command.Concepto;
using _18.Patron.Comportamiento.Command.Ejemplo;

namespace _18.Patron.Comportamiento.Command
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
            // The client code can parameterize an invoker with any commands.
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
        }

        private static void EjecutarEjemplo()
        {
            var modifyPrice = new ModifyPrice();
            var product = new Product("Iphone", 5000);
            var productCommand = new ProdcuctCommand(product, PriceAction.Increase, 27);

            Console.WriteLine($"{product.ToString()}");

            modifyPrice.SetCommand(productCommand);
            modifyPrice.Invoke();

            Console.WriteLine($"{product.ToString()}");

            modifyPrice.Undo();
            modifyPrice.Undo();
            modifyPrice.Undo();
            Console.WriteLine($"{product.ToString()}");
        }
    }
}
