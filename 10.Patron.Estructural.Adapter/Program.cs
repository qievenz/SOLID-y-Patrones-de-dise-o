using System;
using _10.Patron.Estructural.Adapter.Concepto;
using _10.Patron.Estructural.Adapter.EjemploJsonXml;

namespace _10.Patron.Estructural.Adapter
{
    
    class Program
    {
        static void Main(string[] args)
        {
            EjemploXmlToJson();
        }

        private static void EjemploXmlToJson()
        {
            var xmlConverter = new XmlConverter();
            var adapter = new XmlToJsonAdapter(xmlConverter);
            adapter.ConvertXmlToJson();
            Console.ReadLine();
        }

        public static void EjemploConcepto()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Concepto.Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
