﻿using System;
using System.Collections.Generic;

namespace _02.SOLID.OpenClosed
{
  class Program
  {
    static void Main(string[] args)
    {
      var areaCalculator = new AreaCalculator();
      var shapes = new List<IShape>()
      {
          new Rectangle { Width = 40, Height = 20},
         new Circle {Radius = 10}
      };
      
      Console.WriteLine(areaCalculator.Area(shapes));
    }
  }
}
