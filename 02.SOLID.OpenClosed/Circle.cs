using System;

namespace _02.SOLID.OpenClosed
{
  public class Circle : IShape
  {
    public double Radius { get; set; }

    public string Area()
    {
      return "Circulo: " + Radius * Radius * Math.PI;
    }
  }
}