using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Healt_Damage : MonoBehaviour
{
    public int vida = 30;
    public bool invenible = false;
    public float tiempoInve = 1f;
    public float tiempoFren = 0.2f;
    private Animator anim;
    public Text life;

    private void Update()
    {
        life.text = "Vida: " + vida;
    }
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public  void restarVida(int cantidad)
    {
        if (!invenible && vida > 0)
        {
            vida -= cantidad;
            anim.Play("Damage");
            StartCoroutine(timeInvul());
            StartCoroutine(frenVel());
            if (vida  == 0)
            {
                SceneManager.LoadScene("Win");
            }
        }
    }
    IEnumerator timeInvul()
    {
        invenible = true;
        yield return new WaitForSeconds(tiempoInve);
        invenible = false;
    }

    IEnumerator frenVel()
    {
        var velocidadActual = GetComponent<PlayerMoves>().runSpeed;
        GetComponent<PlayerMoves>().runSpeed = 0;
        yield return new WaitForSeconds(tiempoFren);
        GetComponent<PlayerMoves>().runSpeed = velocidadActual;
    }
}
