using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager OtraCosaEstatica;
    
    public int CantidadVidas;
    public int CantidadVelocidad;
    public int CantidadEnemigos;

    private void Awake()
    {
        OtraCosaEstatica = this;
    }

    public void GameOver()
    {
        print("Game Over");
    }
}