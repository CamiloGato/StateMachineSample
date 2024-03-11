using System;

namespace StateMachine
{
    public abstract class BaseStateMachine<TEnum, TState>
        where TEnum : Enum
        where TState : BaseState
    {
        public TEnum State => Transition.GetEnum(CurrentState);

        private TState CurrentState { get; set; }
        protected abstract TransitionStateBuilder<TEnum, TState> Transition { get; set; }

        public void Update()
        {
            CurrentState.UpdateState();
        }

        public void FixedUpdate()
        {
            CurrentState.FixedUpdateState();
        }
        
        protected abstract void Initialize();
        protected abstract void Close();

        public virtual void TransitionTo(TEnum stateEnum)
        {
            CurrentState?.ExitState();
            CurrentState = Transition.GetState(stateEnum);
            CurrentState?.EnterState();
        }

        public virtual void SetUp()
        {
            Initialize();
            CurrentState = Transition.GetTransitionDefault();
        }

        public virtual void Exit()
        {
            Close();
        }
        
    }
}