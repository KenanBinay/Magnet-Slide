using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public GameObject SpikeObject;
    float Randx;
    Vector3 whereToSpawn;
    public float spawnRate;
    public static float nextSpawn = 0.0f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            Randx = Random.Range(1.81f, -3.24f);

            whereToSpawn = new Vector3(Randx, transform.position.y, transform.position.z);

            Instantiate(SpikeObject, whereToSpawn, Quaternion.identity);
            
        }
    }
}
