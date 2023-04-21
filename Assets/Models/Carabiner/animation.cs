using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public GameObject bolt;
    public GameObject latch;

    public void open()
    {
        
    }

    private void openAnimation()
    {
        bolt.transform.position = Vector3.down * Time.deltaTime ; 
    }
}
