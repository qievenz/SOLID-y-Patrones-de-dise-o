using System;

namespace _07.Patron.Creacional.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            EjemploFactoryMethodConceptual();
            EjemploFactoryMethodUser();
            EjemploFactoryMethodPizzeria();
            EjemploFactoryAbstractPizzeria();

            SolucionEjercicio();
        }

        private static void SolucionEjercicio()
        {
            var student = Ejercicio.Student.Factory.Create("Ivan");
            var student2 = Ejercicio.Student.Factory.Create("Ivan2");
            var student3 = Ejercicio.Student.Factory.Create("Ivan3");
        }

        private static void EjemploFactoryMethodConceptual()
        {
            new Concepto.Client().Main();
        }

        private static void EjemploFactoryAbstractPizzeria()
        {
            FactoryAbstract.PizzaStore nyStore = new FactoryAbstract.NYPizzaStore();
            FactoryAbstract.Pizza pizza = nyStore.OrderPizza(FactoryAbstract.TypeOfPizza.Pepperoni);
            Console.WriteLine($"Pizza {pizza.Name} lista para ser entregada a Rodrigo");
            Console.ReadLine();

            FactoryAbstract.PizzaStore flStore = new FactoryAbstract.FLPizzaStore();
            FactoryAbstract.Pizza otherPizza = flStore.OrderPizza(FactoryAbstract.TypeOfPizza.Neapolitan);
            Console.WriteLine($"Pizza {otherPizza.Name} lista para ser entregada a Rodrigo");
            Console.ReadLine();
        }

        private static void EjemploFactoryMethodPizzeria()
        {
            FactoryMethod.PizzaStore nyStore = new FactoryMethod.NYPizzaStore();
            FactoryMethod.Pizza pizza = nyStore.OrderPizza(FactoryMethod.TypeOfPizza.Pepperoni);
            Console.WriteLine($"Pizza {pizza.Name} lista para ser entregada a Rodrigo");
            Console.ReadLine();
        }

        private static void EjemploFactoryMethodUser()
        {
            var user = FactoryMethod.User.Factory.CreateWithDefaultCountry("Rodrigo", "rodrigo@gmail.com");
          
            Console.WriteLine($"Usuario: {user.Name} Email: {user.Email}, Pais: {user.Country}");
            Console.ReadLine();
        }
    }
}
