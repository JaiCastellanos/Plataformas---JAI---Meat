using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class monedaspuntos : MonoBehaviour
{

    //publica en el inspector pero no para los scripts
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private puntaje puntaje; //acuerdate de poner el cambas




    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);

            puntaje.RestarPuntos(cantidadPuntos);

        }
    }


    
}
