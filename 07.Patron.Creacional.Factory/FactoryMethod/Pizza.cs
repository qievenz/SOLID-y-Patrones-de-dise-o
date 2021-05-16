using System;
using System.Collections.Generic;

namespace _07.Patron.Creacional.Factory.FactoryMethod
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Prepararando: {Name}");
            Console.WriteLine($"Colocando masa: {Dough}");
            Console.WriteLine($"Agregando salsa: {Sauce}");
            Console.WriteLine($"Agregando Capas: {string.Join(",", Toppings)}");

        }
        public void Bake() => Console.WriteLine($"Cocinar por 20 min");
        public void Cut() => Console.WriteLine($"Pizza fue cortada en partes iguales");
        public void Box() => Console.WriteLine($"Pizza colocada en caja oficial");

    }

      public abstract class PizzaStore
       {
            public abstract Pizza CreatePizza(TypeOfPizza type);

            public Pizza OrderPizza(TypeOfPizza type)
            {
                Pizza pizza = CreatePizza(type);
             
                pizza.Prepare();
                pizza.Cut();
                pizza.Box();

                return pizza;
       
            }
        }

    public enum TypeOfPizza
    {
        Pepperoni,
        Neapolitan,
        California
    }
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            //switch (name)
            //{
            //    case "pepperoni":
            //        return new NYPepperoniPizza();
            //    case "Neapolitan":
            //        return new NYNeapolitanPizza();
            //    case "California":
            //        return new NYCaliforniaPizza();
            //    default:
            //        return null;

            //}
            var myType = typeof(Pizza);
            var ns = myType.Namespace;
            
            return (Pizza)Activator.
                CreateInstance(Type.GetType($"{ns}.NY{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
            
        }

    }

    public class FLPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            var myType = typeof(Pizza);
            var ns = myType.Namespace;

            return (Pizza)Activator.
                 CreateInstance(Type.GetType($"{ns}.FL{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
        }

    }


    internal class NYPepperoniPizza : Pizza
        {
            public NYPepperoniPizza()
            {
                Name = "Pepperoni";
                Dough = "delgada";
                Sauce = "Salsa de tomates";
                Toppings.Add("Quesso mozarella");
            }
        }

        internal class NYCaliforniaPizza : Pizza
        {
            public NYCaliforniaPizza()
            {
                Name = "caifornia";
                Dough = "delgada";
                Sauce = "Salsa de tomates";
                Toppings.Add("Quesso mozarella");
            }
        }

        internal class NYNeapolitanPizza : Pizza
        {
            public NYNeapolitanPizza()
            {
                Name = "Napolitana";
                Dough = "delgada";
                Sauce = "Salsa de tomates";
                Toppings.Add("Quesso mozarella");
            }
        }


    #region Florida Pizza
    internal class FLPepperoniPizza : Pizza
    {
        public FLPepperoniPizza()
        {
            Name = "Pepperoni";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }

    internal class FLCaliforniaPizza : Pizza
    {
        public FLCaliforniaPizza()
        {
            Name = "caifornia";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }

    internal class FLNeapolitanPizza : Pizza
    {
        public FLNeapolitanPizza()
        {
            Name = "Napolitana";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }

    #endregion

}
