using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]

public class Ejercicio1 : MonoBehaviour
{
    public float speed;     

    private Rigidbody2D mrb;
    //private Rigidbody2D mrbP2;
    private Vector2 direction;
    //private Vector2 directionP2;

    void Start()
    {
        mrb = GetComponent<Rigidbody2D>();
       
    }

    private void FixedUpdate()
    {
        Direction();
        Speed();
}

    void Direction()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), 0);
       
    }

    void Speed()
    {
        mrb.MovePosition((Vector2)transform.position + (speed * direction * Time.fixedDeltaTime));
    }

  
}



