using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformamovil : MonoBehaviour
{

    [SerializeField] private Transform[] puntosMovimiento; 
    [SerializeField] private float velocidadMovimiento;

    private int siguientePlataforma = 1; //el siguiente lugar al que me movere posicion 1 posicion 2 etc
    private bool ordenPlataformas = true; //orden en el que se movera segun los puntos


    private void Update()  
    {
       
        if (siguientePlataforma +1 >= puntosMovimiento.Length) //si ya llego al final valla pa atra
        {
            ordenPlataformas = false;
        }

        if (siguientePlataforma <= 0)
        {
            ordenPlataformas = true;
        }

                            //posicion actual                 proxima posicion 
        if (Vector2.Distance(transform.position, puntosMovimiento[siguientePlataforma].position) < 0.1f) // si la plataforma esta suficiente cerca de la siguiente para cambiar su destino
            if (ordenPlataformas)     //true      
            {
                siguientePlataforma += 1;
            }
            else   
            {

                siguientePlataforma -= 1;

            }
        
                   
        
                             
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[siguientePlataforma].position, velocidadMovimiento * Time.deltaTime);
                                                                                   //posicion x 

    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(this.transform); 
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null);  
        }
    }


}
