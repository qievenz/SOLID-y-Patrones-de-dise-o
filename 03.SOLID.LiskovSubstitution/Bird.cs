using System;
using System.Collections.Generic;
using System.Text;

namespace _03.SOLID.LiskovSubstitution
{    public class Bird : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Estoy volando");

        }

        public void MakeNoise()
        {
            Console.WriteLine("pio pio");

        }
    }
}
