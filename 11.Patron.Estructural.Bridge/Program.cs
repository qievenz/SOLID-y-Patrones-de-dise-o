using System;
using _11.Patron.Estructural.Bridge.Concepto;
using _11.Patron.Estructural.Bridge.Ejemplo;

namespace _11.Patron.Estructural.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void Ejemplo()
        {
            ReaderApp appWindow7 = new Windows7(new NormalDisplay()) { Text = "Aprendiendo Bridge" };
            appWindow7.Display();
            ReaderApp appWindow10 = new Windows10(new NormalDisplay()) { Text = "Aprendiendo Bridge" };
            appWindow10.Display();


            ReaderApp appWindowReverse7 = new Windows7(new ReverseDisplay()) { Text = "Aprendiendo Bridge" };
            appWindowReverse7.Display();
            ReaderApp appWindowReverse10 = new Windows10(new ReverseDisplay()) { Text = "Aprendiendo Bridge" };
            appWindowReverse10.Display();

            Console.ReadLine();
        }

        public void Concepto()
        {
            Client client = new Client();

            Abstraction abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);
            
            Console.WriteLine();
            
            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}
