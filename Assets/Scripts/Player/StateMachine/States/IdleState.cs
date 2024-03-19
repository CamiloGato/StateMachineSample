using System;
using Player.PlayerInput;
using StateMachine;
using UnityEngine;

namespace Player.StateMachine.States
{
    public class IdleState : IState
    {
        public Action OnFinishState { get; set; }
        
        public IInputSystem InputSystem;

        public void EnterState()
        {
            Debug.Log("Enter in IdleState");
        }

        public void UpdateState()
        {
            
        }

        public void FixedUpdateState()
        {
            
        }

        public void ExitState()
        {
            Debug.Log("Saliste de Idle");

        }
    }
}