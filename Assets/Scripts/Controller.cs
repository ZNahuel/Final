using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public float time = 40f;
    public Text temporizador;
    

    void Start()
    {
        time = 40f;
    }

    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            SceneManager.LoadScene("Win");
        }
        temporizador.text = "Tiempo Restante: " + time;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            time = 1;
            SceneManager.LoadScene("Win");
        }
    }

}
