using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    public static float SpeedCharacter=8f;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
       transform.position -= transform.forward * Time.deltaTime*SpeedCharacter;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DestroyWall")) { Destroy(gameObject); }
    }
}
