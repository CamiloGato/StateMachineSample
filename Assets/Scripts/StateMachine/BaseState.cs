namespace StateMachine
{
    public abstract class BaseState
    {
        protected readonly IStateStrategy Strategy;

        protected BaseState(IStateStrategy strategy)
        {
            Strategy = strategy;
        }

        public virtual void EnterState()
        {
            Strategy.SetUp();
        }

        public virtual void ExitState() {}

        public virtual void UpdateState()
        {
            Strategy.OnUpdate();
        }

        public virtual void FixedUpdateState()
        {
            Strategy.OnFixedUpdate();
        }

        public virtual void AnimUpdateState()
        {
            Strategy.OnAnimUpdate();
        }
    }
}