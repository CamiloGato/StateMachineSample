using Player.PlayerInput;
using Player.StateMachine;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private float velocity;
        [SerializeField] private float force;
        
        private Rigidbody2D _rigidBody2D;
        private IInputSystem _inputSystem;
        private PlayerStateMachine _stateMachine;

        private void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
            _inputSystem = new UnityInputSystem("Horizontal");
            
            _stateMachine = new PlayerStateMachine()
            {
                RigidBody2D = _rigidBody2D,
                Force = force,
                Velocity = velocity,
                InputSystem = _inputSystem
            };
            _stateMachine.Initialize();
            
        }

        private void Update()
        {
            _stateMachine.Update();
        }

        private void FixedUpdate()
        {
            _stateMachine.FixedUpdate();
        }

        private void OnDisable()
        {
            GameManager.OtraCosaEstatica.GameOver();
        }
    }
}