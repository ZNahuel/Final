using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicObjEfects : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray,out hitInfo))
            {

                if (hitInfo.collider.gameObject.tag == "Coin" && hitInfo.collider.gameObject.GetComponent<LogicCoin>().destroyCursor == true)
                {
                    hitInfo.collider.gameObject.GetComponent<LogicCoin>().Efecto();
                    Destroy(hitInfo.collider.gameObject);
                }
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Coin" && other.GetComponent<LogicCoin>().destroyAuto == true)
        {
            other.GetComponent<LogicCoin>().Efecto();
            Destroy(other.gameObject);
        }
        if (other.tag=="Coin")
        {

            if (Input.GetMouseButtonDown(1) && other.GetComponent<LogicCoin>().destroyCursor == false)
            {
                other.GetComponent<LogicCoin>().Efecto();
                Destroy(other.gameObject);
            }
        }
    }
}
