using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour
{
    public float runSpeed = 7;
    public float rotationSpeed = 250;

    public Animator animator;

    private float x, y;

    public Rigidbody rb;
    public float forceeJump = 8f;
    public bool icanJump;

    public float velInicial;
    public float velAgachado;

    public CapsuleCollider colParado;
    public CapsuleCollider colAgachado;
    public GameObject cabeza;
    public headCollition HeadCollition;
    public bool eAgachado;

    public int velCorrer;


    void Start()
    {
        icanJump = false;
        velInicial = runSpeed;
        velAgachado = runSpeed * 0.6f;
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * runSpeed);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)&& !eAgachado && icanJump)
        {
            runSpeed = velCorrer;
            if (y > 0)
            {
                animator.SetBool("Frun", true);
            }
            else
            {
                animator.SetBool("Frun", false);
            }
        }
        else
        {
            animator.SetBool("Frun", false);
            if (eAgachado)
            {
                runSpeed = velAgachado;
            }
            else if (icanJump)
            {
                runSpeed = velInicial;
            }
        }
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");


        animator.SetFloat("velX", x);
        animator.SetFloat("velY", y);
        if (icanJump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("jump", true);
                rb.AddForce(new Vector3(0, forceeJump, 0), ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.LeftControl))
            {
                animator.SetBool("crounch", true);
                //runSpeed = velAgachado;

                colAgachado.enabled = true;
                colParado.enabled = false;

                cabeza.SetActive(true);
                eAgachado = true;
            }
            else
            {
                if (HeadCollition.contadorDeColision <= 0)
                {
                    animator.SetBool("crounch", false);
                    //runSpeed = velInicial;

                    cabeza.SetActive(false);
                    colAgachado.enabled = false;
                    colParado.enabled = true;
                    eAgachado = false;
                }
            }

            animator.SetBool("touchGround", true);
        }
        else
        {
            falling();
        }
    }
    public void falling()
    {
        animator.SetBool("touchGround", false);
        animator.SetBool("jump", false);
    }
}
