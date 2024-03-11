using System;

namespace StateMachine
{
    public abstract class BaseStateMachine<TEnum, TState> where TEnum : Enum where TState : BaseState
    {
        protected BaseState CurrentState { get; set; }
        public abstract TransitionStateBuilder<TEnum, TState> Transition { get; set; }
        
        public abstract void Initialize();
        public abstract void Close();

        public virtual void TransitionTo(TEnum stateEnum)
        {
            CurrentState.ExitState();
            CurrentState = Transition.GetState(stateEnum);
            CurrentState.EnterState();
        }
        
    }
}