using UnityEngine;

namespace StateMachine
{
    public class WalkState : MonoBehaviour, IState
    {
        public void EnterState()
        {
            Debug.Log("Entro en WalkState");
        }

        public void UpdateState()
        {
            Debug.Log("Esta caminando");
        }

        public void FixedUpdateState()
        {
            
        }

        public void ExitState()
        {
            Debug.Log("Salio de WalkState");
        }
    }

    public class IdleState : IState
    {
        public void EnterState()
        {
            Debug.Log("Entraste en Idle");
        }

        public void UpdateState()
        {
            Debug.Log("estas kieto");
        }

        public void FixedUpdateState()
        {
            
        }

        public void ExitState()
        {
            Debug.Log("Saliste de Idle");

        }
    }
    
    public class JumpState : IState
    {
        public void EnterState()
        {
            Debug.Log("Entrasde a Jump");
        }

        public void UpdateState()
        {
            Debug.Log("anda saltando");
        }

        public void FixedUpdateState()
        {
            
        }

        public void ExitState()
        {
            Debug.Log("saliste de Jump");
        }
    }

    public class AttackState : IState
    {
        public void EnterState()
        {
            Debug.Log("Entraste en atack");
        }

        public void UpdateState()
        {
            Debug.Log("estas atacando");
        }

        public void FixedUpdateState()
        {
            
        }

        public void ExitState()
        {
            Debug.Log("Saliste de Idle");

        }
    }

    public class DieState : IState
    {
        public void EnterState()
        {
            Debug.Log("Cami NO ME OIDES");
        }

        public void UpdateState()
        {
            Debug.Log("Cami DESCANSO PORFA1");
        }

        public void FixedUpdateState()
        {
            Debug.Log("Cami DESCANSO PORFA2");
        }

        public void ExitState()
        {
            Debug.Log("Cami DESCANSO PORFA3");
        }
    }
    public class MoveState : IState
    {
       // public Rigidbody2D Rb;
        public Transform Tf;
        public float Speed;
        public void EnterState()
        {
            Debug.Log("Cami perdoncito");
        }

        public void UpdateState()
        {
            //Rb.velocity = new Vector2(1f,0f)*Speed;
            Debug.Log("DESCANSO2");

        }

        public void FixedUpdateState()
        {
            //Debug.Log("DESCANSO2");
            Tf.Translate(1f*Speed, 0f, 0f);
        }

        public void ExitState()
        {
            Debug.Log("DESCANSO3");
        }
    }
}