using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicCoin : MonoBehaviour
{
    public bool destroyAuto;
    public PlayerMoves playerMoves;

    void Start()
    {
        playerMoves = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoves>();
    }


    public void Efecto()
    {
                playerMoves.velInicial += 5;
    }

}
