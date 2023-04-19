using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWithGravity : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnInterval = 1f;

    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);

            Rigidbody rb = spawnedObject.AddComponent<Rigidbody>();
            rb.useGravity = true;


            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
