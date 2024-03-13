﻿using UnityEngine;

namespace Player.Input
{
    public class UnityInputSystem : IInputSystem
    {
        private readonly string _horizontal;

        public UnityInputSystem(string horizontal)
        {
            _horizontal = horizontal;
        }

        public float Horizontal()
        {
            return UnityEngine.Input.GetAxis(_horizontal);
        }

        public bool Attack()
        {
            return UnityEngine.Input.GetKeyDown(KeyCode.Q);
        }

        public bool Skill()
        {
            return UnityEngine.Input.GetKeyDown(KeyCode.E);
        }
    }
}