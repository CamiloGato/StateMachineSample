using System;
using Player.Input;
using StateMachine;
using UnityEngine;

namespace Player
{
    [Serializable]
    public enum PlayerStatesEnum
    {
        Idle,
        Jump,
        Walk
    }

    public class PlayerStateMachine : BaseStateMachine<PlayerStatesEnum, BaseState>
    {
        public override StateContainer<PlayerStatesEnum, BaseState> CreateContainter()
        {
            var container = 
                new StateContainer<PlayerStatesEnum, BaseState>()
                    .AddState(PlayerStatesEnum.Idle, new IdleState())
                    .AddState(PlayerStatesEnum.Jump, new JumpState())
                    .AddState(PlayerStatesEnum.Walk, new WalkState())
                    .AddDefaultState(PlayerStatesEnum.Idle);
            
            return container;
        }
    }
    
    public class Player : MonoBehaviour
    {
        private IInputSystem _inputSystem;
        private PlayerStateMachine _stateMachine;

        private void Awake()
        {
            _stateMachine = new PlayerStateMachine();
            _stateMachine.Initialize();
            
            _inputSystem = new UnityInputSystem("Horizontal");
        }

        private void Update()
        {
            _stateMachine.Update();
            
            if (UnityEngine.Input.GetKeyDown(KeyCode.W))
            {
                _stateMachine.TransitionTo( PlayerStatesEnum.Idle );
            }
            else if (UnityEngine.Input.GetKeyDown(KeyCode.S))
            {
                _stateMachine.TransitionTo( PlayerStatesEnum.Jump );
            }
            else if (UnityEngine.Input.GetKeyDown(KeyCode.D))
            {
                _stateMachine.TransitionTo( PlayerStatesEnum.Walk );
            }

        }

        private void FixedUpdate()
        {
            _stateMachine.FixedUpdate();
        }
    }
}