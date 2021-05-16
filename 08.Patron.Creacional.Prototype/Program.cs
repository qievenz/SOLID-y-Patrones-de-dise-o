using System;

namespace _08.Patron.Creacional.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            EjemploConceptual();
            EjemploDeepCopy();
        }

        private static void EjemploDeepCopy()
        {
            new DeepCopy.Client().Main();
        }

        private static void EjemploConceptual()
        {
            new Concepto.Client().Main();
        }
    }
}
