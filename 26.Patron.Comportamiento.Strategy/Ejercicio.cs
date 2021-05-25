using System;

namespace Coding.Exercise
{
   public interface IShapeStrategy
    {
        string Draw();
    }

    public class Circle : IShapeStrategy
    {
        public string Draw()
        {
            return "Dibujando circulo";
        }
    }

    public class Square : IShapeStrategy
    {
        public string Draw()
        {
            return "Dibujando cuadrado";
        }
    }

    public class Context
    {
        private IShapeStrategy _shape;

        public Context(IShapeStrategy shape)
        {
            _shape = shape;
        }

        public string Draw()
        {
            return _shape.Draw();
        }
        

    }
}
