using System.Collections;
using UnityEngine;

public class ToggleObjects : MonoBehaviour
{
    // Assign your GameObjects in the Unity Editor
    public GameObject objectToDeactivate;
    public GameObject objectToActivate;
    public GameObject objectToActivate2; // Added third GameObject
    public GameObject objectToActivate3; // Added fourth GameObject
    public GameObject objectToActivate4; // Added a fifth GameObject

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

            // Wait for the specified interval
            yield return new WaitForSeconds(toggleInterval);

            // Toggle the objects again
            objectToActivate.SetActive(false);
            objectToActivate2.SetActive(true);

            // Wait for the specified interval
            yield return new WaitForSeconds(toggleInterval);

            // Toggle the objects again
            objectToActivate2.SetActive(false);
            objectToActivate3.SetActive(true);

            // Wait for the specified interval
            yield return new WaitForSeconds(toggleInterval);

            // Toggle the objects again
            objectToActivate3.SetActive(false);
            objectToActivate4.SetActive(true);

            // Wait for the specified interval
            yield return new WaitForSeconds(toggleInterval);

            // Toggle the objects again
            objectToActivate4.SetActive(false);
            objectToDeactivate.SetActive(true);

            // No need to swap GameObject references, as they will be cycled in the same order every time.
        }
    }
}
