namespace _02.SOLID.OpenClosed
{
  public class Rectangle : IShape
  {
    public double Width { get; set; }
    public double Height { get; set; }

    public string Area()
    {
      return "Rectangulo: " + Width * Height;
    }
  }
}