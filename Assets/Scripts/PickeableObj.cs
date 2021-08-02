using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickeableObj : MonoBehaviour
{
    public bool isPickeable = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "InteracionZone")
        {
            other.GetComponentInParent<PlayerMoves>().ObjectToPickup = this.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "InteracionZone")
        {
            other.GetComponentInParent<PlayerMoves>().ObjectToPickup = null;
        }
    }
}
