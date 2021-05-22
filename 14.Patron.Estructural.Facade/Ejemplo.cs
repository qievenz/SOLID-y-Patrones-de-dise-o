using System;

namespace _14.Patron.Estructural.Facade.Ejemplo
{
    public class HomeController
    {
        private WifiController _wifiController = new WifiController();
        private ACController _acController = new ACController();
        private LuzController _luzController = new LuzController();
        public void TurnOn()
        {
            _wifiController.TurnOn();
            _acController.TurnOn();
            _luzController.TurnOn();
            
        }
        public void TurnOff()
        {
            _wifiController.TurnOff();
            _acController.TurnOff();
            _luzController.TurnOff();
            
        }
    }
    public class WifiController
    {
        public void TurnOn()
        {
            Console.WriteLine($"Wifi On");
            
        }
        public void TurnOff()
        {
            Console.WriteLine($"Wifi Off");
            
        }
    }
    public class ACController
    {
        public void TurnOn()
        {
            Console.WriteLine($"AC On");
            
        }
        public void TurnOff()
        {
            Console.WriteLine($"AC Off");
            
        }
    }
    
    public class LuzController
    {
        public void TurnOn()
        {
            Console.WriteLine($"Luz On");
            
        }
        public void TurnOff()
        {
            Console.WriteLine($"Luz Off");
            
        }
    }
}