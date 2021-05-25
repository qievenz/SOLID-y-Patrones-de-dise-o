using System;
using System.Text;

namespace _28.Patron.Comportamiento.Visitor.EjemploClaseExterna
{
    public abstract class Shape
    {
        //public abstract void Print(StringBuilder sb);
    }

    public class Circle : Shape
    {
        public int Radius {get;}

        public Circle(int radius)
        {
            Radius = radius;
        }
    }

    public class Square : Shape
    {
        public int Size {get;}

        public Square(int size)
        {
            Size = size;
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
    }

    public static class ShapePrint
    {
        public static void Print(Shape shape, StringBuilder sb)
        {
            if (shape is Circle)
            {
                sb.AppendLine($"<circulo>");
                sb.AppendLine($"<radio value={((Circle)shape).Radius}/>");
                sb.AppendLine($"</circulo>");
            }
            if (shape is Square)
            {
                sb.AppendLine($"<cuadrado>");
                sb.AppendLine($"<tamaño value={((Square)shape).Size}/>");
                sb.AppendLine($"</cuadrado>");
            }
            if (shape is JoinShapes jp)
            {
                sb.AppendLine($"<figuras>");
                Print(jp.Left, sb);
                Print(jp.Right, sb);
                sb.Append("</figuras>");
            }
        }
    }
    public static class EjemploClaseExternaCliente
    {
        public static void Ejecutar()
        {
            var shapes = new JoinShapes(
                left: new Circle(10),
                right: new Square(7)
            );

            var sb = new StringBuilder();
            ShapePrint.Print(shapes, sb);
            Console.WriteLine($"{sb}");
        }
    }
}
