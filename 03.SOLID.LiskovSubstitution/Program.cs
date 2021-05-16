using System;

namespace _03.SOLID.LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Dog();
            animal.MakeNoise();
            //animal.Fly();
            Console.ReadLine();

        }
    }
}
