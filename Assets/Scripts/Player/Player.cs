﻿using System;
using Player.Input;
using StateMachine;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        private IInputSystem _inputSystem;
        private StateMachineStates _stateMachine;
        
        private void Awake()
        {
            _stateMachine = new StateMachineStates( new WalkState() );
            _inputSystem = new UnityInputSystem("Horizontal");
        }

        private void Update()
        {
            _stateMachine.Update();
            // if (Input.GetKeyDown(KeyCode.A))
            // {
            //     _stateMachine.TransitionTo( EnumStates.Attack );
            // }
            // else if (Input.GetKeyDown(KeyCode.W))
            // {
            //     _stateMachine.TransitionTo(EnumStates.Walk);
            // }
            // else if (Input.GetKeyDown(KeyCode.S))
            // {
            //     _stateMachine.TransitionTo(EnumStates.Idle);
            // }

        }

        private void FixedUpdate()
        {
            _stateMachine.FixedUpdate();
        }
    }
}