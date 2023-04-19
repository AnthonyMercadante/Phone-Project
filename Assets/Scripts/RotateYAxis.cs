using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateYAxis : MonoBehaviour
{
    public float rotationSpeed = 30f;

    void Update()
    {
        float rotation = rotationSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(0, rotation, 0));
    }
}

