using System;
using System.Collections.Generic;

namespace _25.Patron.Comportamiento.State.Ejercicio
{
    public class StatePattern
    {
        public enum State
        {
            Green,
            Yellow,
            Red
        }

        public enum Action
        {
            Stop,
            Caution,
            Continue
        }

        public static Dictionary<State, Dictionary<Action, State>> StateMachine
            = new Dictionary<State, Dictionary<Action, State>>
            {
                [State.Green] = new Dictionary<Action, State>
                {
                    {Action.Stop, State.Red},
                    {Action.Caution, State.Yellow}
                },
                [State.Yellow] = new Dictionary<Action, State>
                {
                    {Action.Stop, State.Red}
                },
                [State.Red] = new Dictionary<Action, State>
                {
                    {Action.Continue, State.Green}
                }
            };

    }
}
