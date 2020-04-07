using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]  //Asigna un rigidbody directamente al objeto

public class Bullet : MonoBehaviour
{

    public float speed = 10f;
    public float timeToDestroy = 2f;
    private Rigidbody2D mrb;

    
    void Start()
    {
        mrb = gameObject.GetComponent<Rigidbody2D>();
        mrb.velocity = Vector2.up * speed;
        Destroy(gameObject, timeToDestroy);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player2"))
        {
            Debug.Log("Hola");
        }

    }
    
 
}
