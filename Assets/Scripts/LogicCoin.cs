using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicCoin : MonoBehaviour
{
    public bool destroyCursor;
    public bool destroyAuto;
    public PlayerMoves playerMoves;
    public int tipo;


    void Start()
    {
        playerMoves = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoves>();
    }

    void Update()
    {
        
    }

    public void Efecto()
    {
        switch (tipo)
        {
            case 1:
                playerMoves.gameObject.transform.localScale = new Vector3(2, 2, 2);
                break;
            case 2:
                playerMoves.velInicial += 10;
                break;
            case 3:
                playerMoves.forceeJump += 10;
                break;

            default:
                Debug.Log("Sin efecto");
                break;
        }
    }
}
