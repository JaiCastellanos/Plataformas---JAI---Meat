using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cierraenmovimiento : MonoBehaviour
{

    [SerializeField] private Transform[] puntosMovimiento; //lista con los puntos por lo que pasa la pltaforma
    [SerializeField] private float velocidadMovimiento;

    private int siguientePlataforma = 1;
    private bool ordenPlataformas = true;


    private void Update()
    {
        if (ordenPlataformas && siguientePlataforma + 1 >= puntosMovimiento.Length)
        {
            ordenPlataformas = false;
        }

        if (!ordenPlataformas && siguientePlataforma <= 0)
        {
            ordenPlataformas = true;
        }


        if (Vector2.Distance(transform.position, puntosMovimiento[siguientePlataforma].position) < 0.1f)
        {
            if (ordenPlataformas)
            {
                siguientePlataforma += 1;
            }
            else
            {

                siguientePlataforma -= 1;

            }
        }

        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[siguientePlataforma].position, velocidadMovimiento * Time.deltaTime);


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {


                                       // para obtener la escena activa actual y el método "buildIndex" para obtener el índice de compilación de la escena actual.

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
    }




}
