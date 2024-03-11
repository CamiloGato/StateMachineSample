using StateMachine;

namespace Player.StateMachine.States
{
    public abstract class BasePlayerState : BaseState
    {
        protected BasePlayerState(IStateStrategy strategy) : base(strategy) {}
    }
}