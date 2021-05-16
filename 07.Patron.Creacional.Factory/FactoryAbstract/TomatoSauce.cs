using System;
using static System.Console;
namespace _07.Patron.Creacional.Factory.FactoryAbstract
{
    internal class TomatoSauce : ISauce
    {
        public TomatoSauce()
        {
            Write("Agregando salsa de tomate en lata" + Environment.NewLine);
        }
    }
}