namespace StateMachine
{
    public abstract class BaseState
    {
        private readonly IStateStrategy _strategy;

        protected BaseState(IStateStrategy strategy)
        {
            _strategy = strategy;
        }

        public virtual void EnterState()
        {
            _strategy.SetUp();
        }

        public virtual void ExitState()
        {
            _strategy.Dispose();
        }

        public virtual void UpdateState()
        {
            _strategy.OnUpdate();
        }

        public virtual void FixedUpdateState()
        {
            _strategy.OnFixedUpdate();
        }
    }
}