using System.Collections;
using UnityEngine;

public class MoveObjectZAxis : MonoBehaviour
{
    [SerializeField] private float distance = 5.0f; // Set this to the desired distance in the Inspector
    private float timeToMove = 30.0f; // Fixed time to move the object

    void Start()
    {
        StartCoroutine(MoveZAxis());
    }

    IEnumerator MoveZAxis()
    {
        Vector3 startPosition = transform.position;
        Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y + distance, transform.position.z);
        float elapsedTime = 0.0f;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / timeToMove);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition; // Ensure the object reaches the target position
        Destroy(gameObject); // Destroy the object once it reaches its destination
    }
}
