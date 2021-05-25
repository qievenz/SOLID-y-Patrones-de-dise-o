using _26.Patron.Comportamiento.Strategy.Concepto;
using _26.Patron.Comportamiento.Strategy.Ejemplo;
using _26.Patron.Comportamiento.Strategy.EjemploReflection;

namespace _26.Patron.Comportamiento.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ConceptoClient.Ejecutar();
            EjemploReflectionCliente.Ejecutar();
            EjemploCliente.Ejecutar();
        }
    }
}
