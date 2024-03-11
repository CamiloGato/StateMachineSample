using StateMachine;

namespace Player.StateMachine.States.Jump
{
    public class JumpPlayerState : BasePlayerState
    {
        public JumpPlayerState(IStateStrategy strategy) : base(strategy) {}
    }
}