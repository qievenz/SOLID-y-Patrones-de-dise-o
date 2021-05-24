using System;
using System.Text.RegularExpressions;

namespace _19.Patron.Comportamiento.Interpreter.Ejercicio
{
   public class ExpressionParser
    {
       public int Calculate(string expression)
        {
            var nextOp = Operation.Nothing;
            int current = 0;
            var tokens = Regex.Split(expression, @"(?<=[+-])");
 
            foreach (var token in tokens)
            {
                var noOperator = token.Split(new[] { "+", "-" }, StringSplitOptions.RemoveEmptyEntries);
                var first = noOperator[0];
                int value;
 
                if (!int.TryParse(first, out value))
                    return 0;
 
                switch (nextOp)
                {
                    case Operation.Nothing:
                        current = value;
                        break;
                    case Operation.Plus:
                        current += value;
                        break;
                    case Operation.Minus:
                        current -= value;
                        break;
                }
 
                if (token.EndsWith("+")) nextOp = Operation.Plus;
                else if (token.EndsWith("-")) nextOp = Operation.Minus;
            }
            return current;
        }
 
        public enum Operation
        {
            Nothing,
            Plus,
            Minus
        }
    }
}