using UnityEngine;

namespace Player.StateMachine.States.Transition
{
    public class DistanceTransition : MonoBehaviour
    {
        public EnumPlayerState state;
        public Player player;

        private void OnTriggerEnter2D(Collider2D other)
        {
            player.onStateChange.Invoke(state);
        }
    }
}