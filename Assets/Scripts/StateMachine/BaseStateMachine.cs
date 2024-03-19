using System;

namespace StateMachine
{
    
    public abstract class BaseStateMachine <TEnum>
        where TEnum : Enum
    {
        private IState _currentState;
        private StateContainer<TEnum> _stateContainer;
        
        protected abstract StateContainer<TEnum> CreateStateContainer();

        public void Initialize()
        {
            _stateContainer = CreateStateContainer();
            _currentState = _stateContainer.GetDefaultState();
            _currentState.EnterState();
        }

        public void TransitionTo(TEnum newState)
        {
            _currentState.ExitState();
            _currentState = _stateContainer.GetStateByEnum(newState);
            _currentState.EnterState();
        }

        public void Update()
        {
            _currentState.UpdateState();
        }

        public void FixedUpdate()
        {
            _currentState.FixedUpdateState();
        }
    }
}