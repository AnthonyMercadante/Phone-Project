using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableGameObject : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
        }
    }
}
