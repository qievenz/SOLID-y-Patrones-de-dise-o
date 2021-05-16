using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Patron.Creacional.Factory.FactoryAbstract
{
    public class FLPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ParmessanoCheese();
        }

        public IDough CreateDough()
        {
            return new IThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new TomatoSauce();
        }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie> { new Onion(), new Garlic() };
        }
    }
}
