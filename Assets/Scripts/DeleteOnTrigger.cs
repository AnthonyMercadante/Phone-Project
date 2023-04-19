using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Delete the other game object
        Destroy(other.gameObject);
    }
}
