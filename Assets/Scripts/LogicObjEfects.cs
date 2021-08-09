using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicObjEfects : MonoBehaviour
{
    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Coin" && other.GetComponent<LogicCoin>().destroyAuto == true)
        {
            other.GetComponent<LogicCoin>().Efecto();
            Destroy(other.gameObject);
        }
    }
}
