using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xd : MonoBehaviour
{
    public float fuerzaSalto = 4f; // Fuerza del salto
    public Rigidbody2D playerRigidbody; // Referencia al rigidbody del jugador

    private void Start()
    {
        playerRigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();  //busca el rb del jugadro
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerRigidbody.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }
}
