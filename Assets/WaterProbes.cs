using System.Collections;
using UnityEngine;

public class WaterProbes : MonoBehaviour
{
    public float translationDistance = 10f; // The distance you want to move the object
    public float translationDuration = 30f; // The duration of the movement (in seconds)

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        StartCoroutine(MoveOnYAxis());
    }

    private IEnumerator MoveOnYAxis()
    {
        float elapsedTime = 0f;
        Vector3 targetPosition = startPosition + new Vector3(0, translationDistance, 0);

        while (elapsedTime < translationDuration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / translationDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the object reaches the exact target position at the end
        transform.position = targetPosition;
    }
}
