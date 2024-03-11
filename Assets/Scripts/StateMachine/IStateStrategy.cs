namespace StateMachine
{
    public interface IStateStrategy
    {
        public void SetUp();
        public void OnUpdate();
        public void OnFixedUpdate();
        public void OnAnimUpdate();
    }
}