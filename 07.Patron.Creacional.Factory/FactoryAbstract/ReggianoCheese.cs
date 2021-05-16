using System;
using static System.Console;
namespace _07.Patron.Creacional.Factory.FactoryAbstract
{
    internal class ReggianoCheese : ICheese
    {
        public ReggianoCheese()
        {
            Write("Agregando queso reggiano"  +Environment.NewLine);
        }
    }
}