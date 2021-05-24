using System;
using static _19.Patron.Comportamiento.Interpreter.Ejemplo.NumericExpression;

namespace _19.Patron.Comportamiento.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "2 1 5 + *";
            var parser = new ExpressionParser();
            int result = parser.Parse(input);
            Console.WriteLine($"resultado: {result}");
        }
    }
}
