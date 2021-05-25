using System;

namespace _22.Patron.Comportamiento.Mediator.Ejemplo
{
    public interface IAirTrafficControlMediator
    {
        void RegisterRunway(Runway runway);
        void RegisterFlihgt(Flight flight);
        void SetLandingStatus(bool status);
        bool IsLandOk();
    }

    public class AirTrafficControlMediator : IAirTrafficControlMediator
    {
        private Flight _flight;
        private Runway _runway;
        private bool _land;

        public bool IsLandOk()
        {
            return _land;
        }

        public void RegisterFlihgt(Flight flight)
        {
            _flight = flight;
        }

        public void RegisterRunway(Runway runway)
        {
            _runway = runway;
        }

        public void SetLandingStatus(bool status)
        {
            _land = status;
        }
    }

    public class Flight
    {
        private IAirTrafficControlMediator _mediator;
        public Flight(IAirTrafficControlMediator mediator)
        {
            _mediator = mediator;
        }

        public void Land()
        {
            if(_mediator.IsLandOk())
            {
                Console.WriteLine($"Se puede aterrizara");
            }
            else
            {
                Console.WriteLine($"No se puede aterrizar");
            }
        }
    }

    public class Runway
    {
        private IAirTrafficControlMediator _mediator;

        public Runway(IAirTrafficControlMediator mediator)
        {
            _mediator = mediator;
            _mediator.SetLandingStatus(false);
        }
        public void Land()
        {
            Console.WriteLine($"Permiso para aterrizar");
            _mediator.SetLandingStatus(true);
        }
    }
}