using System;
using static System.Console;
namespace _07.Patron.Creacional.Factory.FactoryAbstract
{
    internal class IThinCrustDough : IDough
    {
        public IThinCrustDough()
        {
            Write("Agregando masa delgada" + Environment.NewLine);
        }
    }
}