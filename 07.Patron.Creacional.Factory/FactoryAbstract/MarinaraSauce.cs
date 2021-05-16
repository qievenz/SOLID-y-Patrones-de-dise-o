using System;
using static System.Console;
namespace _07.Patron.Creacional.Factory.FactoryAbstract
{
    internal class MarinaraSauce : ISauce
    {
        public MarinaraSauce()
        {
            Write("Agregando salsa marinara" + Environment.NewLine);
        }
    }
}