namespace StateMachine
{
    public abstract class BaseStateMachine
    {
        public BaseState CurrentState { get; set; }
        
        public abstract void Enter();
        public abstract void Close();
        
        public abstract void ChangeState(BaseState baseState);
    }
}