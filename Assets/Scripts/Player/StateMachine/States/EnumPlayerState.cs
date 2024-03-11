using System;

namespace Player.StateMachine.States
{
    [Serializable]
    public enum EnumPlayerState
    {
        Idle,
        Walk,
        Jump,
        Run,
        Attack,
    }
}