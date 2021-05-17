using System;
using System.Collections.Generic;
using System.IO;

namespace _09.Patron.Creacional.Singleton
{
    public class SingletonDataContainer : ISingletonContainer
    {
        private Dictionary<string, int> _capitals = new Dictionary<string, int>();
        private SingletonDataContainer()
        {
            var elements = File.ReadAllLines("db/capitals.txt");

            for (int i = 0; i < elements.Length; i += 2)
            {
                _capitals.Add(elements[i], int.Parse(elements[i+1]));
            }
        }
        //Lazy hace que se cree en el primer uso, en lugar de cuando arranca la aplicacion
        private static Lazy<SingletonDataContainer> _instance = new Lazy<SingletonDataContainer>(() => new SingletonDataContainer());
        public static SingletonDataContainer Instance => _instance.Value;
        public int GetPopulation(string name)
        {
            return _capitals[name];
        }
    }
}
