using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class monedas : MonoBehaviour
{
    private float puntoscoleccionables;
    private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {

        textMesh.text = puntoscoleccionables.ToString("0");
    }

    public void SumarPuntos(float puntosEntrada)
    {
        puntoscoleccionables += puntosEntrada;
    }
}
