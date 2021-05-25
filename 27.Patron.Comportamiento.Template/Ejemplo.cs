using System;

namespace _27.Patron.Comportamiento.Template.Ejemplo
{
    public abstract class Bread
    {
        public abstract void MixIngredients();
        public abstract void Bake();
        public virtual void Slice()
        {
            Console.WriteLine($"Cortando pan {GetType().Name}");
        }

        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }
    }

    public class Blanco : Bread
    {
        public override void Bake()
        {
            Console.WriteLine($"Horneando pan blanco");
        }

        public override void MixIngredients()
        {
            Console.WriteLine($"Colocando ingredientes pan blanco");
        }
    }

    public class Integral : Bread
    {
        public override void Bake()
        {
            Console.WriteLine($"Horneando pan integral");
        }

        public override void MixIngredients()
        {
            Console.WriteLine($"Colocando ingredientes pan integral");
        }
    }
    public static class EjemploCliente
    {
        public static void Ejecutar()
        {
            var blanco = new Blanco();
            blanco.Make();

            var integral = new Integral();
            integral.Make();
        }
    }
}
