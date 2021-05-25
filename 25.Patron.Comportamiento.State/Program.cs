using System;
using _25.Patron.Comportamiento.State.Concepto;
using _25.Patron.Comportamiento.State.Ejemplo;
using _25.Patron.Comportamiento.State.EjemploStateless;
using Stateless;

namespace _25.Patron.Comportamiento.State
{
    class Program
    {
        public static bool GanarLoteria { get; private set; }

        static void Main(string[] args)
        {
            EjecutarConcepto();
            EjecutarEjempĺoStateless();
            EjecutarEjemplo();
        }

        private static void EjecutarConcepto()
        {
            // The client code.
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
        }

        private static void EjecutarEjempĺoStateless()
        {
            var statem = new StateMachine<EmployeeState, EmployeeActions>(EmployeeState.Cesante);

            statem.Configure(EmployeeState.Cesante)
                .Permit(EmployeeActions.PasarEntrevista, EmployeeState.ConEmpleo);

            statem.Configure(EmployeeState.ConEmpleo)
                .Permit(EmployeeActions.ObtenerBuenaEvaluacion, EmployeeState.DeJefe)
                .PermitIf(EmployeeActions.JugarLoteria, EmployeeState.Millonario,
                    () => GanarLoteria);

            statem.Configure(EmployeeState.ConEmpleo)
                .Permit(EmployeeActions.BorrarEmpleado, EmployeeState.Cesante);
        }

        private static void EjecutarEjemplo()
        {
            var state = PhoneState.Colgado;

            while (true)
            {
                Console.WriteLine($"Estado actual: {state}");
                Console.WriteLine($"Seleccione opcion:");

                for (int i = 0; i < Rules.PhoneRules[state].Count; i++)
                {
                    var (t, _) = Rules.PhoneRules[state][i];
                    Console.WriteLine($"{i}. {t}");
                }

                var input = int.Parse(Console.ReadLine());

                var (_, s) = Rules.PhoneRules[state][input];
                state = s;

            }
        }
    }
}
