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

    public class WalkState : BaseState
    {
        public override void Enter()
        {
            Debug.Log("Entro en WalkState");
        }

        public override void Update()
        {
            Debug.Log("Esta caminando");
        }

        public override void FixedUpdate()
        {
            
        }

        public override void Exit()
        {
            Debug.Log("Salio de WalkState");
        }
    }

    public class IdleState : BaseState
    {
        public override void Enter()
        {
            Debug.Log("Entraste en Idle");
        }

        public override void Update()
        {
            Debug.Log("estas kieto");
        }

        public override void FixedUpdate()
        {
            
        }

        public override void Exit()
        {
            Debug.Log("Saliste de Idle");

        }
    }
    
    public class JumpState : BaseState
    {
        public override void Enter()
        {
            Debug.Log("Entrasde a Jump");
        }

        public override void Update()
        {
            Debug.Log("anda saltando");
        }

        public override void FixedUpdate()
        {
            
        }

        public override void Exit()
        {
            Debug.Log("saliste de Jump");
        }
    }
}