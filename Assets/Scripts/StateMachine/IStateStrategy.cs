namespace StateMachine
{
    public interface IStateStrategy
    {
        public void SetUp();
        public void Dispose();
        public void OnUpdate();
        public void OnFixedUpdate();
    }
}