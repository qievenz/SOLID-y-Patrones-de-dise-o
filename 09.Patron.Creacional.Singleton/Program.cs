using System;

namespace _09.Patron.Creacional.Singleton
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            var capitals = SingletonDataContainer.Instance;

            Console.WriteLine($"Habitantes: {capitals.GetPopulation("London")}");
            
        }
    }
}
