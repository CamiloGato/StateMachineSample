using UnityEngine;

namespace Player.StateMachine.States.Transition
{
    public class DistanceTransition : MonoBehaviour
    {
        public EnumPlayerState state;
        public Player player;

        private void OnTriggerEnter2D(Collider2D other)
        {
            var next = other.gameObject;
            player.onStateChange.Invoke(state);
        }
    }
}