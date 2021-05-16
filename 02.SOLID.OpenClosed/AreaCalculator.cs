using System;
using System.Collections.Generic;

namespace Client
{
  public class AreaCalculator
  {
    public string Area(List<IShape> shapes)
    {
      string area = "";
      foreach (var shape in shapes)
      {
        area += shape.Area();
        area += Environment.NewLine;
      }
      return area;
    }
  }
}