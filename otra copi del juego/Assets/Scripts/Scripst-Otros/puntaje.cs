using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class puntaje : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>(); //para poder modificaf mi texrto
    }

    private void Update()
    {
        puntos += Time.deltaTime;

       
        if (puntos >= 60)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        textMesh.text = puntos.ToString("0"); //para que incie en 0 y sea sin decimales 
    }

    public void RestarPuntos(float puntosEntrada)
    {
        if (puntosEntrada > puntos)
        {
            puntos = 0;
        }
        else
        {
            puntos -= puntosEntrada;
        }
    }

}
