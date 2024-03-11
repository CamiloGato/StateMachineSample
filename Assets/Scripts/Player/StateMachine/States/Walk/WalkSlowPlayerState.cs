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

        public override void OnUpdate()
        {
            Debug.Log("Nia ich ni san Nia Update");
        }

        public override void OnFixedUpdate()
        {
            Debug.Log("Nia ich ni san Nia Fixed Update");
        }

        public override void OnAnimUpdate()
        {
            Debug.Log("Nia ich ni san Nia Anim Update");
        }
    }
}