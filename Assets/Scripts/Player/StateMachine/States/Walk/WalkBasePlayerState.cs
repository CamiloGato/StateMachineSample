﻿using StateMachine;
using UnityEngine;

namespace Player.StateMachine.States.Walk
{
    public abstract class WalkBasePlayerState : ScriptableObject, IStateStrategy
    {
        public virtual void SetUp() {}
        public virtual void Dispose() {}

        public virtual void OnUpdate() {}

        public virtual void OnFixedUpdate() {}
    }
}