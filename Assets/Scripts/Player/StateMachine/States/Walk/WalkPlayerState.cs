using StateMachine;

namespace Player.StateMachine.States.Walk
{
    public class WalkPlayerState : BasePlayerState
    {
        public WalkPlayerState(IStateStrategy strategy) : base(strategy) {}
    }
}