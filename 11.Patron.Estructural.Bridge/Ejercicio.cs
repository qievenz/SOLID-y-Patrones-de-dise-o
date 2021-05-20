using System;

namespace _11.Patron.Estructural.Bridge.Ejercicio
{
    public abstract class Employee
    {
        public string Name { get; set; }
        private IContactType _contactType;
 
        public Employee(IContactType contactType)
        {
            _contactType = contactType;
        }
        public override string ToString()
        {
            return $"{Name} ha sido contactado por {_contactType.Type}";
        }
    }
    
    public interface IContactType
    {
        string Type { get; }
    }
 
    public class PhoneCall : IContactType
    {
        public string Type => "telefono";
    }
    public class Email : IContactType
    {
        public string Type => "email";
    }
 
 
    public class Developer : Employee
    {
        public Developer(IContactType contactType) : base(contactType)
        {
           Name = "Developer";
        }
    }
 
 
    public class ScrumMaster : Employee
    {
        public ScrumMaster(IContactType contactType) : base(contactType)
        {
            Name = "ScrumMaster";
        }
    }
}