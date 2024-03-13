using System;
using UnityEngine;

namespace StateMachine
{
    
    public class StateMachineStates
    {
        private BaseState _currentState;

        public StateMachineStates(BaseState currentState)
        {
            _currentState = currentState;
        }

        public void TransitionTo(BaseState newState)
        {
            _currentState = newState;
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