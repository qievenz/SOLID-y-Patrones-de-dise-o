using System;
using System.Collections.Generic;
using System.Text;

namespace _03.SOLID.LiskovSubstitution
{
    public class Dog : IAnimal
    {
        public void MakeNoise()
        {
            Console.WriteLine("wow wow");
            
        }
    }
}
