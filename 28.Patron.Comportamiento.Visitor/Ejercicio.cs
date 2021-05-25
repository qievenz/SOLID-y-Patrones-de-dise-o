using System;
using System.Text;
namespace Coding.Exercise
{
    public interface IExpressionVisitor
    {
        void Visit(Number number);
        void Visit(AdditionExpression additionExpression);
    }

    public abstract class Expression
    {
        public abstract void Accept(IExpressionVisitor visitor);
    }

    public class Number : Expression
    {
        public readonly int Value;

        public Number(int value)
        {
            Value = value;
        }

        public override void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class AdditionExpression : Expression
    {
        public readonly Expression LeftValue, RightValue;

        public AdditionExpression(Expression leftValue, Expression rightValue)
        {
            LeftValue = leftValue;
            RightValue = rightValue;
        }

        public override void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    

    public class ExpressionPrinter : IExpressionVisitor
    {
        private StringBuilder sb = new StringBuilder();

        public void Visit(Number value)
        {
            sb.Append(value.Value);
        }

        public void Visit(AdditionExpression addition)
        {
            addition.LeftValue.Accept(this);
            sb.Append("+");
            addition.RightValue.Accept(this);
        }


        public override string ToString() => sb.ToString();
    }

    public static class EjercicioCliente
    {
        public static void Ejecutar()
        {
            var lvalue = new Number(5);
            var rvalue = new Number(6);
            var addition = new AdditionExpression(lvalue, rvalue);
            
            var print = new ExpressionPrinter();
            print.Visit(addition);
            
            Console.WriteLine($"{print.ToString()}");
        }
    }

}
