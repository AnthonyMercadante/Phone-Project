using System.Collections.Generic;
using UnityEngine;

public class DeleteIfNotIgnored : MonoBehaviour
{
    [SerializeField] private List<GameObject> ignoreList; // Assign GameObjects to ignore in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        bool shouldDelete = true;

        foreach (GameObject ignoreObj in ignoreList)
        {
            if (other.gameObject == ignoreObj)
            {
                shouldDelete = false;
                break;
            }
        }

        if (shouldDelete)
        {
            Destroy(other.gameObject);
        }
    }
}
