using System;
using StateMachine;
using UnityEngine;

namespace Player.StateMachine.States
{
    public class JumpState : IState
    {
        public Action OnFinishState { get; set; }
        
        public Rigidbody2D Rb;
        public float Force;

        public void EnterState()
        {
            Debug.Log("Enter Jump State");
        }

        public void UpdateState()
        {
            
        }

        public void FixedUpdateState()
        {
            
        }

        public void ExitState()
        {
            Debug.Log("Exit Jump State");
        }
    }
}