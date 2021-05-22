using System;
using _16.Patron.Estructural.Proxy.Concepto;
using _16.Patron.Estructural.Proxy.Ejemplo;

namespace _16.Patron.Estructural.Proxy
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
            Client client = new Client();
            
            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            ProxyClass proxy = new ProxyClass(realSubject);
            client.ClientCode(proxy);
        }

        private static void EjecutarEjemplo()
        {
            ICar car = new CarProxy(new Driver(13, true));
            car.Drive();
        }
    }
}
