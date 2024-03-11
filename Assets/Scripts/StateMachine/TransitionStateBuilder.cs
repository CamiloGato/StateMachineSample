using System;
using System.Collections.Generic;

namespace StateMachine
{
    public class TransitionStateBuilder<TEnum, TState>
        where TEnum : Enum
        where TState : BaseState
    {
        private readonly Dictionary<TEnum, TState> _transitionsStates = new Dictionary<TEnum, TState>();
        private TState _defaultState;
        
        public TransitionStateBuilder<TEnum, TState> DefaultTransitionState(TEnum @enum)
        {
            _defaultState = GetState(@enum);
            return this;
        }
        
        public TransitionStateBuilder<TEnum, TState> AddTransitionState( TEnum @enum, TState state )
        {
            _transitionsStates.Add(@enum, state);
            return this;
        }

        public TransitionStateBuilder<TEnum, TState> Build()
        {
            if (_defaultState == null)
            {
                throw new MissingDefaultStateException();
            }
            return this;
        }

        public TState GetState(TEnum @enum)
        {
            if (_transitionsStates.TryGetValue(@enum, out TState state))
            {
                return state;
            }

            throw new MissingStateException(@enum);
        }

        public TState GetTransitionDefault()
        {
            return _defaultState ?? throw new Exception(" No Default Transition");
        }

        public TEnum GetEnum(TState state)
        {
            foreach (TEnum statesKey in _transitionsStates.Keys)
            {
                if (_transitionsStates[statesKey] == state)
                {
                    return statesKey;
                }
            }

            return default;
        }
    }
}