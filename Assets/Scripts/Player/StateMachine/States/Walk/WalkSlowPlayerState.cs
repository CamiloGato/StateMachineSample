using UnityEngine;

namespace Player.StateMachine.States.Walk
{
    [CreateAssetMenu(fileName = "Slow", menuName = "Player/State Machine/Walk", order = 0)]
    public class WalkSlowPlayerState : WalkBasePlayerState
    {
        public override void SetUp()
        {
            Debug.Log("Nia ich ni san Nia SetUp");
        }

        public override void Dispose()
        {
            Debug.Log("Nia ich ni san Nia Dispose");
        }

        public override void OnUpdate()
        {
        }

        public override void OnFixedUpdate()
        {
        }
    }
}