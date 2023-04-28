using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class monedastxt : MonoBehaviour
{


    [SerializeField] private float cantidadPuntos;
    [SerializeField] private monedas puntaje;




    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);

            puntaje.SumarPuntos(cantidadPuntos);

        }
    }



}
