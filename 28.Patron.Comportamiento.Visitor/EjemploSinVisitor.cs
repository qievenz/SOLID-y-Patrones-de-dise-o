using System;
using System.Text;

namespace _28.Patron.Comportamiento.Visitor.EjemploSinVisitor
{
    public abstract class Shape
    {
        public abstract void Print(StringBuilder sb);
    }

    public class Circle : Shape
    {
        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public override void Print(StringBuilder sb)
        {
            sb.AppendLine($"<circulo>");
            sb.AppendLine($"<radio value={_radius}/>");
            sb.AppendLine($"</circulo>");
        }
    }

    public class Square : Shape
    {
        private int _size;

        public Square(int size)
        {
            _size = size;
        }

        public override void Print(StringBuilder sb)
        {
            sb.AppendLine($"<cuadrado>");
            sb.AppendLine($"<tamaño value={_size}/>");
            sb.AppendLine($"</cuadrado>");
        }
    }

    public class JoinShapes : Shape
    {
        private Shape left, right;

        public JoinShapes(Shape left, Shape right)
        {
            this.left = left;
            this.right = right;
        }

        public override void Print(StringBuilder sb)
        {
            sb.AppendLine($"<figuras>");
            left.Print(sb);
            right.Print(sb);
            sb.Append("</figuras>");
        }
    }
    public static class EjemploSinVisitorCliente
    {
        public static void Ejecutar()
        {
            var shapes = new JoinShapes(
                left: new Circle(10),
                right: new Square(7)
            );

            var sb = new StringBuilder();
            shapes.Print(sb);
            Console.WriteLine($"{sb}");
        }
    }
}
