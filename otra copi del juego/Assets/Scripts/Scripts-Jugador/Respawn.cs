using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private float checkpointPosicionX;
    private float checkpointPosicionY;


    // verifica si se ha guardado alguna posici�n de checkpoint previamente. Si es as�, el jugador se mover� a esa posici�n guardada en el checkpoint.
    void Start()   
    {

//para almacenar y recuperar datos del jugador 
        if (PlayerPrefs.GetFloat("checkpointPosicionX") != 0)
        {
            //mandar el jugador a esa posicion
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkpointPosicionX"), PlayerPrefs.GetFloat("checkpointPosicionY")));
        }
    }
    

    public void PasarPorElcheckpoint(float x, float y)
    {


        PlayerPrefs.SetFloat("checkpointPosicionX",x);
        PlayerPrefs.SetFloat("checkpointPosicionY", y);
    }


}
