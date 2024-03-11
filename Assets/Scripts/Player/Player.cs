using System;
using Player.StateMachine;
using Player.StateMachine.States;
using Player.StateMachine.States.Jump;
using Player.StateMachine.States.Walk;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        public Action<EnumPlayerState> onStateChange;
        
        [Header("Player States Requirements")]
        [SerializeField] private WalkBasePlayerState walkStrategy;
        [SerializeField] private JumpBasePlayerState jumpStrategy;
        
        private PlayerStateMachine _playerStateMachine;

        private void Awake()
        {
            onStateChange += ChangeState;
            
            WalkBasePlayerState walkState = Instantiate(walkStrategy);
            JumpBasePlayerState jumpState = Instantiate(jumpStrategy);
            
            _playerStateMachine = new PlayerStateMachine(walkState, jumpState);
            _playerStateMachine.SetUp();
        }

        private void ChangeState(EnumPlayerState state)
        {
            _playerStateMachine.TransitionTo(state);
        }

        private void Update()
        {
            _playerStateMachine.Update();
        }

        private void FixedUpdate()
        {
            _playerStateMachine.FixedUpdate();
        }

        private void OnDestroy()
        {
            onStateChange -= ChangeState;
            
            _playerStateMachine.Exit();
        }
    }
}