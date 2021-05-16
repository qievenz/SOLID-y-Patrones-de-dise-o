using System;

namespace _07.Patron.Creacional.Factory.FactoryAbstract
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            
            var myType = typeof(PizzaStore);
            var ns = myType.Namespace;

            return (Pizza)Activator.
                CreateInstance(Type.GetType($"{ns}.{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"), ingredientFactory);
        }

    }

}