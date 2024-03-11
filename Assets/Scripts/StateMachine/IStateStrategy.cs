namespace StateMachine
{
    public interface IStateStrategy
    {
        public void OnUpdate();
        public void OnFixedUpdate();
        public void OnAnimUpdate();
    }
}