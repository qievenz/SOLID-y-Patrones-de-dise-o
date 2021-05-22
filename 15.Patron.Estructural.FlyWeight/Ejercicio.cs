using System.Collections.Generic;

namespace _15.Patron.Estructural.FlyWeight.Ejercicio
{
   public interface IShape
    {
        string Print();
    }

    public class Rectangle : IShape
    {
        public string Print()
        {
            return "Imprimiendo rectangulo";
           
        }
    }

    public class Circle : IShape
    {
        public string Print()
        {
          return "Imprimiendo circulo";
        }
    }


    public class ShapeObjectFactory
    {
        Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public int TotalObjectsCreated
        {
            get { return shapes.Count; }
        }

        public IShape GetShape(string ShapeName)
        {
           IShape shape = null;
            if(shapes.ContainsKey(ShapeName))
            {
                shape = shapes[ShapeName];
            }
            else
            {
                switch (ShapeName)
                {
                    case "Rectangle":
                        shape = new Rectangle();
                        break;
                    case "Circle":
                        shape = new Circle();
                        break;
                    default:
                        break;
                }

                shapes.Add(ShapeName, shape);
            }

            return shape;
        }
    }
}