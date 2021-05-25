using System;

namespace _23.Patron.Comportamiento.NullObject.Ejercicio
{
  public interface IMobile
    {
        void TurnOn();
     }

     public class SamsungGalaxy : IMobile
    {
        public void TurnOn()
        {
        }
    }

    public class Iphone : IMobile
    {
        public void TurnOn()
        {
         }
    }

    public class NullMobile : IMobile
    {

        public void TurnOn()
        {
            
        }
    }


    public class MobileRepository
    {
        public IMobile GetMobileByName(string mobileName)
        {
            IMobile mobile = null;
            switch (mobileName)
            {
                case "samsung":
                    mobile = new SamsungGalaxy();
                    break;

                case "apple":
                    mobile = new Iphone();
                    break;
                default:
                    mobile = new NullMobile();
                    break;
            }
            return mobile;
        }
    }
}
