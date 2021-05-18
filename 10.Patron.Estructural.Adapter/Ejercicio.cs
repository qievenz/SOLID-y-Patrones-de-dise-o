using System;

namespace Coding.Exercise
{
   public interface IEuropeanPlugConnector
    {
        string GiveElectricity();
    }

    public class EuropeanElectricalConnector : IEuropeanPlugConnector
    {
        public string GiveElectricity()
        {
            return "Dando electricidad";
        }
    }
    
    public interface USPlugConnector
    {
        string ProvideElectricity();
    }

    public class EuropeanToUSAdapter : USPlugConnector
    {
        private readonly EuropeanElectricalConnector _adaptee;

        public EuropeanToUSAdapter(EuropeanElectricalConnector adaptee)
        {
            this._adaptee = adaptee;
        }

        public string ProvideElectricity()
        {
            return _adaptee.GiveElectricity();
        }
    }

}