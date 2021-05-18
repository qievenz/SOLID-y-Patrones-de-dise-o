using System;

namespace _24.Patron.Comportamiento.Observer.Eventos
{
    public class InterviewUpdateEventArgs : EventArgs
    {
        //Private set evita que los datos suscriptores puedan modificar los datos
        //Si los suscriptores modifican, ese cambio se refleja a todos los suscriptores
        public string Name { get; private set; }

        public InterviewUpdateEventArgs(string name)
        {
            Name = name;
        }

    }
}