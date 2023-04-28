using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemigo : MonoBehaviour
{
    public Transform target; //puede actualizar constantemente su dirección hacia el objetivo accediendo al componente Transformar del objetivo para obtener su posición actual.
    public float speed = 5f; 

    private void Update()
    {
        if (target != null)
        {
            // Obtener la dirección hacia el objetivo
            Vector3 direction = (target.position - transform.position).normalized;


            transform.position += direction * speed * Time.deltaTime;

        }


        
    }
    

    private void OnCollisionEnter2D(Collision2D other)
    {
          if (other.gameObject.CompareTag("Player"))
          {
              Destroy(other.gameObject);
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
          }
    }
}

