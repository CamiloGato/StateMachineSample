using UnityEngine;

namespace StateMachine
{
    public abstract class BaseState
    {
        public abstract void Enter();
        public abstract void Update();
        public abstract void FixedUpdate();
        public abstract void Exit();
    }

    class WalkState : BaseState
    {
        public override void Enter()
        {
            Debug.Log("Entro en WalkState");
        }

        public override void Update()
        {
            
        }

        public override void FixedUpdate()
        {
            
        }

        public override void Exit()
        {
            Debug.Log("Salio de WalkState");
        }
    }
}