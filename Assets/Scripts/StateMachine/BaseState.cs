namespace StateMachine
{
    public abstract class BaseState
    {
        private readonly IStateStrategy _strategy;

        protected BaseState(IStateStrategy strategy)
        {
            _strategy = strategy;
        }

        public virtual void EnterState() {}

        public virtual void ExitState() {}

        public virtual void UpdateState()
        {
            _strategy.OnUpdate();
        }

        public virtual void FixedUpdateState()
        {
            _strategy.OnFixedUpdate();
        }

        public virtual void AnimUpdateState()
        {
            _strategy.OnAnimUpdate();
        }
    }
}