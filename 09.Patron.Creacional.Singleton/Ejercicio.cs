using System;

namespace _09.Patron.Creacional.Singleton.Ejercicio
{
    public class Person
    {
        public string Name {get;set;}

        private static Person _instance = new Person();
        public static Person Instance => _instance;
    }
    

}
