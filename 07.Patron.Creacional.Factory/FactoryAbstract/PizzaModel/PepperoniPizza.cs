using static System.Console;
namespace _07.Patron.Creacional.Factory.FactoryAbstract
{
    internal class PepperoniPizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;
        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            WriteLine($"Prepararando: {Name}");
            Dough = _ingredientFactory.CreateDough();
            Cheese = _ingredientFactory.CreateCheese();
            Sauce = _ingredientFactory.CreateSauce();
            Veggies = _ingredientFactory.CreateVeggies();
        }
    }

}