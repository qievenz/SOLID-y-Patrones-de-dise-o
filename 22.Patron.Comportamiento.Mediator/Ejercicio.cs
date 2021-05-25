using System;

namespace _22.Patron.Comportamiento.Mediator.Ejercicio
{
  public interface IPlayMediator
    {
        void RegisterPlayRoom(PlayRoom playRoom);
        void RegisterBoy(Boy boy);
        bool IsPlayRoomAvailable();
        void SetPlayRoomAvailability(bool status);

    }

    public class PlayMediator : IPlayMediator
    {
        private bool _playRoomAvailable;
        private Boy _boy;
        private PlayRoom _playRoom;
        public bool IsPlayRoomAvailable()
        {
            return _playRoomAvailable;
        }

        public void RegisterBoy(Boy boy)
        {
            _boy = boy;
        }

        public void RegisterPlayRoom(PlayRoom playRoom)
        {
            _playRoom = playRoom;
        }

        public void SetPlayRoomAvailability(bool status)
        {
            _playRoomAvailable = status;
        }
    }

    public class Boy
    {
        private IPlayMediator _mediator;

        public Boy(IPlayMediator mediator)
        {
            _mediator = mediator;
        }

        public bool Play()
        {
           return _mediator.IsPlayRoomAvailable();
        }
    }

    public class PlayRoom
    {
        private IPlayMediator _mediator;

        public PlayRoom(IPlayMediator mediator)
        {
            _mediator = mediator;
            _mediator.SetPlayRoomAvailability(false);

        }

        public void GivePermission()
        {
            _mediator.SetPlayRoomAvailability(true);
        }


    }
}
