using System;
using System.Collections.Generic;
namespace Coding.Exercise
{
  public interface IIterator<T>
  {
      bool hasNext();
      T Next();
  }
    public class Shape
    {
        public string Name { get; private set; }
    
        public Shape(string name)
        {
            Name = name;
        
        }

    }

    public class ShapeCollection
    {
        private List<Shape> _shapes;

        public ShapeCollection()
        {
            _shapes = new List<Shape>();
            AddItem("Circulo");
            AddItem("Cuadrado");
            AddItem("Rectangulo");

        }

        public void AddItem(string name)
        {
            Shape shape = new Shape(name);
            _shapes.Add(shape);
        }

        public IIterator<Shape> CreateIterator() => new ShapeIterator(_shapes);
    }

    public class ShapeIterator : IIterator<Shape>
    {
        List<Shape> items;
        int position = 0;

        public ShapeIterator(List<Shape> items)
        {
            this.items = items;
        }

        public bool hasNext()
        {
            return position < items.Count && items[position] != null;
        }

        public Shape Next()
        {
            var shape = items[position];
            position++;
            return shape;
        }
    }
}
