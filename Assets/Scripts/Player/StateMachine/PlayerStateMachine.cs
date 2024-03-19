using Player.PlayerInput;
using Player.StateMachine.States;
using StateMachine;
using UnityEngine;

namespace Player.StateMachine
{
    public class PlayerStateMachine : BaseStateMachine<PlayerStatesEnum>
    {
        public Rigidbody2D RigidBody2D;
        public IInputSystem InputSystem;
        public float Velocity;
        public float Force;
        
        protected override StateContainer<PlayerStatesEnum> CreateStateContainer()
        {
            GameManager.OtraCosaEstatica.GameOver();
            StateContainer<PlayerStatesEnum> container = 
                new StateContainer<PlayerStatesEnum>()
                    .AddState(
                        PlayerStatesEnum.Idle,
                        new IdleState()
                        {
                        }
                    )
                    .AddState(
                        PlayerStatesEnum.Jump,
                        new JumpState()
                        {
                            Rb = RigidBody2D,
                            Force = Force,
                        }
                    )
                    .AddState(
                        PlayerStatesEnum.Walk, 
                        new WalkState()
                        {
                            Rb = RigidBody2D,
                            InputSystem = InputSystem,
                            Velocity = Velocity,
                        }
                    )
                    .AddDefaultState(PlayerStatesEnum.Idle);
            
            return container;
        }
    }
}