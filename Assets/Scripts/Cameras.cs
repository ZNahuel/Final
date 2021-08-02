using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public Camera cams;
    
    void Start()
    {
        cams.enabled = false;
    }

    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var myCam = cams;

            foreach (var cam in Camera.allCameras)
            {
                cam.enabled = false;
            }
            myCam.enabled = true;
        }
    }


}
