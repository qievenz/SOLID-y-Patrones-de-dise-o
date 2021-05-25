using System.Collections.Generic;

namespace _25.Patron.Comportamiento.State.Ejemplo
{
    public enum PhoneState
    {
        Colgado,
        Descolgado,
        Llamando,
        Conectando,
        EnEspera,
    }
    public enum PhoneTrigger
    {
        Descolgar,
        MarcarLlamada,
        Colgar,
        Conectado,
        DejarMensaje,
        DejaeEnEspera,
        QuitarEspera
    }

    public static class Rules
    {
        public static Dictionary<PhoneState, List<(PhoneTrigger, PhoneState)>> PhoneRules
            = new Dictionary<PhoneState, List<(PhoneTrigger, PhoneState)>>
            {
                [PhoneState.Colgado] = new List<(PhoneTrigger, PhoneState)>
                {
                    (PhoneTrigger.Descolgar, PhoneState.Descolgado)
                },
                [PhoneState.Descolgado] = new List<(PhoneTrigger, PhoneState)>
                {
                    (PhoneTrigger.MarcarLlamada, PhoneState.Llamando)
                },
                [PhoneState.Llamando] = new List<(PhoneTrigger, PhoneState)>
                {
                    (PhoneTrigger.Colgar, PhoneState.Colgado),
                    (PhoneTrigger.Conectado, PhoneState.Conectando)
                },
                [PhoneState.Conectando] = new List<(PhoneTrigger, PhoneState)>
                {
                    (PhoneTrigger.Colgar, PhoneState.Colgado),
                    (PhoneTrigger.DejaeEnEspera, PhoneState.EnEspera),
                    (PhoneTrigger.DejarMensaje, PhoneState.Colgado),
                },
                [PhoneState.EnEspera] = new List<(PhoneTrigger, PhoneState)>
                {
                    (PhoneTrigger.QuitarEspera, PhoneState.Conectando),
                },
            };
    }
}