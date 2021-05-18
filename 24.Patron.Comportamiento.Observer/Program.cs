using System;
using _24.Patron.Comportamiento.Observer.Eventos;
using _24.Patron.Comportamiento.Observer.EventosWeak;
using _24.Patron.Comportamiento.Observer.ObserverPuro;

namespace _24.Patron.Comportamiento.Observer
{
    class Program
    {
        
        static void Main(string[] args)
        {
            EjemploRestaurant();

            EjemploEventos();

            EjemploEventosMemoryLeak();
        }

        private static void EjemploEventosMemoryLeak()
        {
            //La fuga de memoria se da porque el boton sigue vinculado al Form
            //incluso luego de setear el form a null
            //Otra forma seria usando IDisposable
            //https://stackoverflow.com/questions/29064682/why-is-the-implementation-of-events-in-c-sharp-not-using-a-weak-event-pattern-by/
            var button = new Button();
            var form = new Form(button);
            var formRef = new WeakReference(form);
            button.Click();
            Console.WriteLine("Cambiar form a null");
            form = null;
            GarbageCollector.FireGC();
            Console.WriteLine($"El objeto sigue activo? {formRef.IsAlive}");
        }

        private static void EjemploEventos()
        {
            var recruiter = new Recruiter();

            recruiter.InterviewUpdate += CallApplicant;

            recruiter.LastInterview("ivan");
        }

        private static void CallApplicant(object sender, InterviewUpdateEventArgs e)
        {
            Console.WriteLine($"El postulante {e.Name} fue contactado");
        }

        private static void EjemploRestaurant()
        {
            var limon = new Limon(0.82);
            
            limon.Attach(new Restaurant("La paella", 0.77));
            limon.Attach(new Restaurant("Otro Rest", 0.73));
            limon.Attach(new Restaurant("los hdp", 0.75));

            limon.PricePerKg = 0.79;
            limon.PricePerKg = 0.76;
            limon.PricePerKg = 0.74;
            limon.PricePerKg = 0.81;
        }
    }
}
