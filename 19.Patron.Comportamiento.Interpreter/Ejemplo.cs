using System;
using System.Collections.Generic;

namespace _19.Patron.Comportamiento.Interpreter.Ejemplo
{
    public interface IExpression
    {
        int Interpret();
    }

    public class NumericExpression : IExpression
    {
        private int _number;

        public NumericExpression(int number)
        {
            _number = number;
        }

        public NumericExpression(string number)
        {
            _number = int.Parse(number);
        }

        public class AdditionExpression : IExpression
        {
            private IExpression _firstExpression, _secondExpression;

            public AdditionExpression(IExpression firstExpression, IExpression secondExpression)
            {
                _firstExpression = firstExpression;
                _secondExpression = secondExpression;
            }

            public int Interpret()
            {
                return _firstExpression.Interpret() + _secondExpression.Interpret();
            }

            public override string ToString()
            {
                return $"+";
            }
        }
        public class SubstractionExpression : IExpression
        {
            private IExpression _firstExpression, _secondExpression;

            public SubstractionExpression(IExpression firstExpression, IExpression secondExpression)
            {
                _firstExpression = firstExpression;
                _secondExpression = secondExpression;
            }

            public int Interpret()
            {
                return _firstExpression.Interpret() - _secondExpression.Interpret();
            }

            public override string ToString()
            {
                return $"-";
            }
        }

        public class MultiplyExpression : IExpression
        {
            private IExpression _firstExpression, _secondExpression;

            public MultiplyExpression(IExpression firstExpression, IExpression secondExpression)
            {
                _firstExpression = firstExpression;
                _secondExpression = secondExpression;
            }

            public int Interpret()
            {
                return _firstExpression.Interpret() * _secondExpression.Interpret();
            }

            public override string ToString()
            {
                return $"*";
            }
        }

        public class ExpressionParser
        {
            private static bool IsOperator(string input) => (input.Equals("+") || input.Equals("-") || input.Equals("*"));

            private static IExpression GetExpression(IExpression firstExpression, IExpression secondExpression, string simbol)
            {
                if(simbol.Equals("+"))
                    return new AdditionExpression(firstExpression, secondExpression);
                else if(simbol.Equals("-"))
                    return new SubstractionExpression(firstExpression, secondExpression);
                else
                    return new MultiplyExpression(firstExpression, secondExpression);
            }
            
            Stack<IExpression> stack = new Stack<IExpression>();
            public int Parse(string input)
            {
                string[] tokenList = input.Split(' ');
                foreach (var item in tokenList)
                {
                    if (!IsOperator(item))
                    {
                        IExpression numberExp = new NumericExpression(item);
                        stack.Push(numberExp);
                        Console.WriteLine($"Agrego {numberExp.Interpret()}");
                    }
                    else if (IsOperator(item))
                    {
                        IExpression firstExp = stack.Pop();
                        IExpression secondExp = stack.Pop();
                        Console.WriteLine($"Expresoines  {firstExp.Interpret()} {secondExp.Interpret()}");
                        IExpression expression = GetExpression(firstExp, secondExp, item);
                        Console.WriteLine($"Aplicando {expression}");
                        NumericExpression resultExp = new NumericExpression(expression.Interpret());
                        stack.Push(resultExp);
                        Console.WriteLine($"Agrego rsultado: {resultExp.Interpret()}");
                    }
                }

                return stack.Pop().Interpret();
            }
        }

        public int Interpret()
        {
            return _number;
        }
    }
}