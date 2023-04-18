using System.Collections;
using UnityEngine;

public class ToggleObjects : MonoBehaviour
{
    // Assign your GameObjects in the Unity Editor
    public GameObject objectToDeactivate;
    public GameObject objectToActivate;
    public GameObject objectToActivate2; // Added third GameObject

    // Time in seconds before switching
    private float toggleInterval = 30.0f;

    private void Start()
    {
        // Start the coroutine to toggle the objects
        StartCoroutine(ToggleRoutine());
    }

    private IEnumerator ToggleRoutine()
    {
        while (true) // Loop forever
        {
            // Wait for the specified interval
            yield return new WaitForSeconds(toggleInterval);

            // Toggle the objects
            objectToDeactivate.SetActive(false);
            objectToActivate.SetActive(true);
            objectToActivate2.SetActive(false); // Deactivate the third object

            // Rotate through the objects for the next iteration
            GameObject temp = objectToDeactivate;
            objectToDeactivate = objectToActivate;
            objectToActivate = objectToActivate2;
            objectToActivate2 = temp;
        }
    }
}
