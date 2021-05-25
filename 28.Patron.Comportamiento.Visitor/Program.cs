
using _28.Patron.Comportamiento.Visitor.Concepto;
using _28.Patron.Comportamiento.Visitor.EjemploClaseExterna;
using _28.Patron.Comportamiento.Visitor.EjemploConVisitor;
using _28.Patron.Comportamiento.Visitor.EjemploSinVisitor;
using Coding.Exercise;

namespace _28.Patron.Comportamiento.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            EjemploSinVisitorCliente.Ejecutar();
            EjemploClaseExternaCliente.Ejecutar();
            EjemploConVisitorCliente.Ejecutar();
            EjercicioCliente.Ejecutar();
            ConceptoCliente.Ejecutar();
        }
    }
}
