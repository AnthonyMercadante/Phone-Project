using UnityEngine;

public class DeleteOnEat : MonoBehaviour
{
    [SerializeField] private GameObject prefab1; // Assign prefab1 in the Inspector
    [SerializeField] private GameObject prefab2; // Assign prefab2 in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == prefab1 || other.gameObject == prefab2)
        {
            Destroy(other.gameObject);
        }
    }
}
