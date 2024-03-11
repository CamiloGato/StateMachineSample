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

        public override void Dispose()
        {
            Debug.Log("El pepe Dispose");
        }

        public override void OnUpdate()
        {
        }

        public override void OnFixedUpdate()
        {
        }
    }
}