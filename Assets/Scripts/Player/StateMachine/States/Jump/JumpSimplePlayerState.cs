using UnityEngine;

namespace Player.StateMachine.States.Jump
{
    [CreateAssetMenu(fileName = "Simple", menuName = "Player/State Machine/Jump", order = 0)]
    public class JumpSimplePlayerState : JumpBasePlayerState
    {
        public override void SetUp()
        {
            Debug.Log("El pepe SetUp");
        }

        public override void OnUpdate()
        {
            Debug.Log("El pepe Update");
        }

        public override void OnFixedUpdate()
        {
            Debug.Log("El pepe FixedUpdate");
        }

        public override void OnAnimUpdate()
        {
            Debug.Log("El pepe Anim Update");
        }
    }
}