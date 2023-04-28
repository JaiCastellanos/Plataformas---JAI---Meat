using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5f; 
    public float fuerzaSalto = 4f; 
    public Rigidbody2D playerRigidbody; 
    public bool estaPresionandoQ = false; 

    public enum ENUM1
    {
        RightArrow = 1,
        LeftArrow = 2,
        Space = 3,
    }


    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>(); // Referencia al rigidbody del jugador
    }


    void Update()
    {



        // Mover hacia la derecha
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * velocidad * Time.deltaTime;
        }




        // Mover hacia la izquierda
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * velocidad * Time.deltaTime;
        }


        //mi saltito
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (revisasuelo.estaensuelo)
            {
                playerRigidbody.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            }
            else if (revisasuelo.estaenpared)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    playerRigidbody.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
                }

            }
        }



        if (revisasuelo.estaenpared && Input.GetKey(KeyCode.Q))
        {
            estaPresionandoQ = true;
            playerRigidbody.bodyType = RigidbodyType2D.Static;

        }
        else
        {
            estaPresionandoQ = false;
            playerRigidbody.bodyType = RigidbodyType2D.Dynamic;
        }



    }
}
