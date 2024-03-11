using System;
using System.Collections.Generic;

namespace StateMachine
{
    public class TransitionStateBuilder<TEnum, TState>
        where TEnum : Enum where TState : BaseState
    {
        private readonly Dictionary<TEnum, TState> _transitionsStates = new Dictionary<TEnum, TState>();

        public TransitionStateBuilder<TEnum, TState> AddTransitionState( TEnum @enum, TState state )
        {
            _transitionsStates.Add(@enum, state);
            return this;
        }

        public TransitionStateBuilder<TEnum, TState> Build()
        {
            return this;
        }

        public TState GetState(TEnum @enum)
        {
            if (_transitionsStates.TryGetValue(@enum, out TState state))
            {
                return state;
            }

            throw new Exception($"No States in {@enum}");
        }
    }
}