using System;

namespace _24.Patron.Comportamiento.Observer.EventosWeak
{
    public class Button
    {
        public event EventHandler Clicked;
        public void Click()
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}