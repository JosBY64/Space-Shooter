using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float cooldown = 0.2f;
    private float lastShootTime = 0;

    
    void Update()
    {

        if (this.gameObject.CompareTag("Player"))
        { 
            if (Time.time > lastShootTime + cooldown || lastShootTime == 0)
                {
                    if (Input.GetKey("space"))
                     { 
                        foreach (Transform child in transform)
                        {
                            Instantiate(bullet, child.position, Quaternion.identity);
                        }
                     }
                    lastShootTime = Time.time;
                }
        }

        else
        {
            if (this.gameObject.CompareTag("Player2"))
            {
                if (Time.time > lastShootTime + cooldown || lastShootTime == 0)
                {
                    if (Input.GetKey("enter"))
                    {
                        foreach (Transform child in transform)
                        {
                            Instantiate(bullet, child.position, Quaternion.identity);
                        }
                    }
                    lastShootTime = Time.time;
                }
            }
        }

    }
}
