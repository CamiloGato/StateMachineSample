using System;
using System.Collections.Generic;

namespace StateMachine
{
    public class StateContainer<TEnum>
        where TEnum : Enum
    {
        private Dictionary<TEnum, IState> _container = new Dictionary<TEnum, IState>();
        private IState _defaultState;
        
        public StateContainer<TEnum> AddState(TEnum type, IState state)
        {
            _container.Add(type, state);
            return this;
        }

        public StateContainer<TEnum> AddDefaultState(TEnum state)
        {
            _defaultState = GetStateByEnum(state);
            return this;
        }

        public IState GetDefaultState()
        {
            return _defaultState 
                   ?? throw new Exception("No se ha asignado un estado por defecto");
        }

        public IState GetStateByEnum( TEnum enumerator )
        {
            return _container.GetValueOrDefault(enumerator) 
                   ?? throw new Exception($"No existe un estado para {enumerator}");
        }
        
    }
}