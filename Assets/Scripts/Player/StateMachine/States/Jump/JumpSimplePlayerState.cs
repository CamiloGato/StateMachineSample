using System;
using UnityEngine;

namespace Player.StateMachine.States.Jump
{
    [CreateAssetMenu(fileName = "Simple", menuName = "Player/State Machine/Jump", order = 0)]
    public class JumpSimplePlayerState : JumpBasePlayerState
    {
        public Rigidbody2D Rb { get; set; }
        
        
        public override void SetUp()
        {
            if (!Rb) throw new Exception("MISSING COMPONENT");
        }

        public override void Dispose() {}

        public override void OnUpdate()
        {
            
        }

        public override void OnFixedUpdate()
        {
        }
    }
}