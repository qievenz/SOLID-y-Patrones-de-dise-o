using System;
using System.Collections.Generic;

namespace _17.Patron.Comportamiento.Chain.Ejemplo
{
    public class Mobile
    {
        public Mobile(string name, MobileType type, double price)
        {
            Type = type;
            Price = price;
            Name = name;
        }

        public MobileType Type {get; private set; }
        public double Price { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} {Type} {Price}";
        }
    }
    public enum MobileType
    {
        Basic,
        Medium,
        Premium
    }

    public abstract class Handler 
    {
        protected Handler _successor;
        protected ISpecification<Mobile> _specification;

        protected Handler(ISpecification<Mobile> specification)
        {
            _specification = specification;
        }

        public void SetSuccessor(Handler handler)
        {
            _successor = handler;
        }

        public abstract void HandleRequest(Mobile mobile);
    }

    public class Employee : Handler
    {
        public Employee(ISpecification<Mobile> specification) : base(specification)
        {
        }

        public override void HandleRequest(Mobile mobile)
        {
            if(CanHandle(mobile))
            {
                Console.WriteLine($"Orden de {mobile.Name} por {this.GetType().Name}");
            }
            else
            {
                _successor.HandleRequest(mobile);
            }
        }
        public bool CanHandle(Mobile mobile)
        {
            return _specification.IsSatisfied(mobile);
        }
    }
    public class Supervisor : Handler
    {
        public Supervisor(ISpecification<Mobile> specification) : base(specification)
        {
        }

        public override void HandleRequest(Mobile mobile)
        {
            if(CanHandle(mobile))
            {
                Console.WriteLine($"Orden de {mobile.Name} por {this.GetType().Name}");
            }
            else
            {
                _successor.HandleRequest(mobile);
            }
        }
        public bool CanHandle(Mobile mobile)
        {
            return _specification.IsSatisfied(mobile);
        }
    }
    public class Ceo : Handler
    {
        public Ceo(ISpecification<Mobile> specification) : base(specification)
        {
        }

        public override void HandleRequest(Mobile mobile)
        {
            if(CanHandle(mobile))
            {
                Console.WriteLine($"Orden de {mobile.Name} por {this.GetType().Name}");
            }
            else
            {
                _successor.HandleRequest(mobile);
            }
        }
        public bool CanHandle(Mobile mobile)
        {
            return _specification.IsSatisfied(mobile);
        }
    }

    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }

    public class MobileBasic : ISpecification<Mobile>
    {
        public bool IsSatisfied(Mobile item)
        {
            return item.Type == MobileType.Basic;
        }
    }
    public class MobileMedium : ISpecification<Mobile>
    {
        public bool IsSatisfied(Mobile item)
        {
            return item.Type == MobileType.Medium;
        }
    }
    public class MobilePremium : ISpecification<Mobile>
    {
        public bool IsSatisfied(Mobile item)
        {
            return item.Type == MobileType.Premium;
        }
    }
}
