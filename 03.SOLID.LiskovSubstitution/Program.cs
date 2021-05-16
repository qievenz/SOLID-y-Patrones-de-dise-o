using System;

namespace _03.SOLID.LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.noise = "AWW";
            animal.MakeNoise();
            animal.Fly();
            Console.ReadLine();

        }
    }
}
