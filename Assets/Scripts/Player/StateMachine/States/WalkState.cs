using System;
using Player.PlayerInput;
using StateMachine;
using UnityEngine;

namespace Player.StateMachine.States
{
    public class WalkState : IState
    {
        public Action OnFinishState { get; set; }
        
        public IInputSystem InputSystem;
        public Rigidbody2D Rb;
        public float Velocity;
        
        private float _horizontal;


        public void EnterState()
        {
            Debug.Log("Enter Walk State");
        }

        public void UpdateState()
        {
            _horizontal = InputSystem.Horizontal();
        }

        public void FixedUpdateState()
        {
            var direction = new Vector2(_horizontal, 0);
            Rb.MovePosition( Rb.position +  direction * Velocity);
        }

        public void ExitState()
        {
            Debug.Log("Exit Walk State");
        }
    }
}