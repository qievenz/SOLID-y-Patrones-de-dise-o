using System;

namespace _24.Patron.Comportamiento.Observer.EventosWeak
{
    public class Form
    {
        public Form(Button button)
        {
            //button.Clicked += ButtonOnClicked;
            System.Windows.WeakEventManager<Button, EventArgs>
                .AddHandler(button, "Clicked", ButtonOnClicked);
        }

        private void ButtonOnClicked(object sender, EventArgs e)
        {
            Console.WriteLine($"El boton fue clickeado");
        }

        ~Form()
        {
            Console.WriteLine($"Formulario finalizado");
        }
    }
}