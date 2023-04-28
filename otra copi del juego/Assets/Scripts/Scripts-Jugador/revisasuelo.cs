using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revisasuelo : MonoBehaviour
{
    public static bool estaensuelo;
    public static bool estaenpared; //stacios para podee usarlos en otr scritps

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pared"))
        {
            estaensuelo = true;
            estaenpared = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pared"))
        {
            estaensuelo = false;
            estaenpared = false;
        }

    }
}
