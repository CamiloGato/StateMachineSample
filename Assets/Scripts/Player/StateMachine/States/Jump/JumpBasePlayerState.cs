using StateMachine;
using UnityEngine;

namespace Player.StateMachine.States.Jump
{
    public abstract class JumpBasePlayerState : ScriptableObject, IStateStrategy
    {
        public virtual void SetUp() {}
        public virtual void Dispose() {}

        public virtual void OnUpdate() {}

        public virtual void OnFixedUpdate() {}
    }
}