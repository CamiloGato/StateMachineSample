using System;
using StateMachine;
using UnityEngine;

namespace Enemy
{
    
    [Serializable]
    public enum EnemyStatesEnum
    {
        Attack,
        Move,
        Die
    }

    public class EnemyStateMachine : BaseStateMachine<EnemyStatesEnum>
    {
        public Rigidbody2D Rb;
        public float Speed;
        public Transform Tfm;
        
        
        protected override StateContainer<EnemyStatesEnum> CreateContainter()
        {
            var container = new StateContainer<EnemyStatesEnum>()
                .AddState(EnemyStatesEnum.Attack,new AttackState())
                .AddState(EnemyStatesEnum.Die, new DieState())
                .AddState(EnemyStatesEnum.Move,
                    new MoveState()
                    {
                        Tf=Tfm,
                        Speed = Speed,
                    }
                
                )
                .AddDefaultState(EnemyStatesEnum.Move);
            
            
            return container;
        }
    }

    public class Enemy : MonoBehaviour
    {
        [SerializeField] private float speed;
        private EnemyStateMachine _stateMachine;

        private void Awake()
        {
            _stateMachine =
                new EnemyStateMachine()
                {
                    Tfm = GetComponent<Transform>(),
                   // Rb = GetComponent<Rigidbody2D>(),
                    Speed = speed
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

        private void OnCollisionEnter2D(Collision2D other)
        {
            _stateMachine.TransitionTo(EnemyStatesEnum.Attack);
        }
    }
}
    
    


