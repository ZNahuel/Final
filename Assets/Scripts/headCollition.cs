using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headCollition : MonoBehaviour
{
    public int contadorDeColision = 0;


    private void OnTriggerStay(Collider other)
    {
        contadorDeColision++;
    }

    private void OnTriggerExit(Collider other)
    {
        contadorDeColision--;
    }
}
