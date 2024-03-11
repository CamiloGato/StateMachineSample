using Player.StateMachine.States;
using StateMachine;

namespace Player.StateMachine
{
    public class PlayerStateMachine : BaseStateMachine<EnumPlayerState, BasePlayerState>
    {
        private TransitionStateBuilder<EnumPlayerState, BasePlayerState> _transition;
        public override TransitionStateBuilder<EnumPlayerState, BasePlayerState> Transition
        {
            get => _transition;
            set => _transition = value;
        }
        
        public override void Initialize()
        {
            // First SetUp Transitions
            _transition = new TransitionStateBuilder<EnumPlayerState, BasePlayerState>();
            _transition.AddTransitionState(EnumPlayerState.Walk, null);
        }

        public override void Close()
        {
            
        }
    }
}