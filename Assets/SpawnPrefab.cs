using System.Collections;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    // Assign your prefab in the Unity Editor
    public GameObject prefabToSpawn;

    // Time in seconds between spawns
    private float spawnInterval = 1.0f;

    private void Start()
    {
        // Start the coroutine to spawn the prefab
        StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (true) // Loop forever
        {
            // Wait for the specified interval
            yield return new WaitForSeconds(spawnInterval);

            // Instantiate the prefab at the current object's position and rotation
            Instantiate(prefabToSpawn, transform.position, transform.rotation);
        }
    }
}
