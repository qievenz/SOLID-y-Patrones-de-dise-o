using System;

namespace _16.Patron.Estructural.Proxy.Ejercicio
{
    public class Person
    {
        public Person(int balance)
        {
            Balance = balance;
        }

        public int Balance { get; set; }

        public string Eat()
        {
            return "comiendo";
        }
            
     }

     public class ProxyPerson
    {
        private Person _person;

        public ProxyPerson(Person person)
        {
            _person = person;
        }

        public string Eat()
        {
            if(_person.Balance > 0)
                return _person.Eat();
            else
                return "no tiene dinero";
        }
    }
}
