using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1P2 : MonoBehaviour
{
    public float speed;

    //private Rigidbody2D mrb;
    private Rigidbody2D mrbP2;
    //private Vector2 direction;
    private Vector2 directionP2;

    void Start()
    {
        mrbP2 = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Direction();
        Speed();
    }

    void Direction()
    {
        directionP2 = new Vector2(Input.GetAxis("Vertical"), 0);

    }

    void Speed()
    {
        mrbP2.MovePosition((Vector2)transform.position + (speed * directionP2 * Time.fixedDeltaTime));
    }

 
}



