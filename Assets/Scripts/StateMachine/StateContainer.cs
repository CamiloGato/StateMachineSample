using System;
using System.Collections.Generic;

namespace StateMachine
{
    public class StateContainer<TEnum, TState>
        where TEnum : Enum
        where TState : BaseState
    {
        private Dictionary<TEnum, TState> _container = new Dictionary<TEnum, TState>();
        private TState _defaultState;
        
        public StateContainer<TEnum, TState> AddState(TEnum type, TState state)
        {
            _container.Add(type, state);
            return this;
        }

        public StateContainer<TEnum, TState> AddDefaultState(TEnum state)
        {
            _defaultState = GetStateByEnum(state);
            return this;
        }

        public TState GetDefaultState()
        {
            return _defaultState 
                   ?? throw new Exception("No se ha asignado un estado por defecto");
        }

        public TState GetStateByEnum( TEnum enumerator )
        {
            return _container.GetValueOrDefault(enumerator) 
                   ?? throw new Exception($"No existe un estado para {enumerator}");
        }
        
    }
}