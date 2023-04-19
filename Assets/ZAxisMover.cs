using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAxisMover : MonoBehaviour
{
    public float speed = 1.0f;
    public float range = 5.0f;

    private float initialPositionZ;
    private float direction = -1.0f;

    void Start()
    {
        initialPositionZ = transform.position.z;
    }

    void Update()
    {
        float newPositionZ = transform.position.z + (direction * speed * Time.deltaTime);

        if (newPositionZ >= initialPositionZ + range || newPositionZ <= initialPositionZ - range)
        {
            direction *= -1;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, newPositionZ);
        }
    }
}
