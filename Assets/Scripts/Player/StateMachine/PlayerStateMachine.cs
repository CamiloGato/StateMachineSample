using Player.StateMachine.States;
using Player.StateMachine.States.Jump;
using Player.StateMachine.States.Walk;
using StateMachine;

namespace Player.StateMachine
{
    public class PlayerStateMachine : BaseStateMachine<EnumPlayerState, BasePlayerState>
    {
        private TransitionStateBuilder<EnumPlayerState, BasePlayerState> _transition;
        protected override TransitionStateBuilder<EnumPlayerState, BasePlayerState> Transition
        {
            get => _transition;
            set => _transition = value;
        }

        private readonly IStateStrategy _walkStateStrategy;
        private readonly IStateStrategy _jumpStateStrategy;

        public PlayerStateMachine(IStateStrategy walkStateStrategy, IStateStrategy jumpStateStrategy)
        {
            _walkStateStrategy = walkStateStrategy;
            _jumpStateStrategy = jumpStateStrategy;
        }

        protected override void Initialize()
        {
            // First SetUp Transitions
            _transition = new TransitionStateBuilder<EnumPlayerState, BasePlayerState>()
                .AddTransitionState(EnumPlayerState.Walk, new WalkPlayerState(_walkStateStrategy))
                .AddTransitionState(EnumPlayerState.Jump, new JumpPlayerState(_jumpStateStrategy))
                .DefaultTransitionState(EnumPlayerState.Walk)
                .Build();
        }

        protected override void Close()
        {
            _transition = null;
        }
    }
}