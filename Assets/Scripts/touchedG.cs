using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchedG : MonoBehaviour
{
    public PlayerMoves playerMoves;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            playerMoves.icanJump = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
            playerMoves.icanJump = false;
    }

}
