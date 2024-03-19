using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
        private void Update()
        {
                print(GameManager.OtraCosaEstatica.CantidadEnemigos);
                GameManager.OtraCosaEstatica.GameOver();
        }
}