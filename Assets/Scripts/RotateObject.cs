using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float speed = 10f; // speed of rotation

    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime); // rotate around the Z-axis
    }
}

