using System;
using UnityEngine;

namespace StateMachine
{
    
    public abstract class BaseStateMachine <TEnum, TState>
        where TEnum : Enum
        where TState : BaseState
    {
        private TState _currentState;
        private StateContainer<TEnum, TState> _stateContainer;

        public void Initialize()
        {
            _stateContainer = CreateContainter();
            _currentState = _stateContainer.GetDefaultState();
            _currentState.Enter();
        }

        public abstract StateContainer<TEnum, TState> CreateContainter();

        public void TransitionTo(TEnum newState)
        {
            _currentState.Exit();
            _currentState = _stateContainer.GetStateByEnum(newState);
            _currentState.Enter();
        }

        public void Update()
        {
            _currentState.Update();
        }

        public void FixedUpdate()
        {
            _currentState.FixedUpdate();
        }
        
    }
}