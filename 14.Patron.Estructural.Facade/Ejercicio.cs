using System;

namespace _14.Patron.Estructural.Facade.Ejercicio
{
    public class MusicController
    {
        public static bool IsOn { get; private set; }
        public void TurnOn() => IsOn = true;
        public void TurnOff() => IsOn = false;
    }

    public class RunningController
    {
        public static bool IsOn { get; private set; }
        public void TurnOn() => IsOn = true;
        public void TurnOff() => IsOn = false;
    }

    public class RunningApp
    {
        private MusicController _musicController = new MusicController();
        private RunningController _runningController = new RunningController();

        public void GoRunning()
        {
            _musicController.TurnOn();
            _runningController.TurnOn();
        }

        public void CompleteRunning()
        {
            _musicController.TurnOff();
            _runningController.TurnOff();
        }
    }
}
