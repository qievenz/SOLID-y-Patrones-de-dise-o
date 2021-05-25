using System;
using System.Text;

namespace _28.Patron.Comportamiento.Visitor.EjemploConVisitor
{
    public abstract class Shape
    {
        //public abstract void Print(StringBuilder sb);
        public abstract void Accept(IShapeVisitor shapeVisitor);
    }

    public interface IShapeVisitor
    {
        void Visit(Square square);
        void Visit(Circle circle);
        void Visit(JoinShapes joinShapes);
    }

    public class Circle : Shape
    {
        public int Radius {get;}

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override void Accept(IShapeVisitor shapeVisitor)
        {
            shapeVisitor.Visit(this);
        }
    }

    public class Square : Shape
    {
        public int Size {get;}

        public Square(int size)
        {
            Size = size;
        }

        public override void Accept(IShapeVisitor shapeVisitor)
        {
            shapeVisitor.Visit(this);
        }
    }

    public class JoinShapes : Shape
    {
        public Shape Left {get;}
        public Shape Right {get;}

        public JoinShapes(Shape left, Shape right)
        {
            this.Left = left;
            this.Right = right;
        }

        public override void Accept(IShapeVisitor shapeVisitor)
        {
            shapeVisitor.Visit(this);
        }
    }

    public class ShapePrint : IShapeVisitor
    {
        StringBuilder sb = new StringBuilder();

        public void Visit(Square square)
        {
            sb.AppendLine($"<cuadrado>");
            sb.AppendLine($"<tamaño value={square.Size}/>");
            sb.AppendLine($"</cuadrado>");
        }

        public void Visit(Circle circle)
        {
            sb.AppendLine($"<circulo>");
            sb.AppendLine($"<radio value={circle.Radius}/>");
            sb.AppendLine($"</circulo>");
        }

        public void Visit(JoinShapes joinShapes)
        {
            sb.AppendLine($"<figuras>");
            joinShapes.Left.Accept(this);
            joinShapes.Right.Accept(this);
            sb.Append("</figuras>");
        }

        public override string ToString()
        {
            return sb.ToString();
        }
    }

    public static class EjemploConVisitorCliente
    {
        public static void Ejecutar()
        {
            var shapes = new JoinShapes(
                left: new Circle(10),
                right: new Square(7)
            );
            
            var print = new ShapePrint();

            print.Visit(shapes);
            
            Console.WriteLine($"{print.ToString()}");
        }
    }
}
