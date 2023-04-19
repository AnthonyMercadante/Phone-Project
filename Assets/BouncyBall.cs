using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class BouncyBall : MonoBehaviour
{
    public PhysicMaterial bouncyMaterial;

    private void Start()
    {
        // Ensure the GameObject has a Rigidbody component
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = true;

        // Ensure the GameObject has a Collider component
        Collider col = GetComponent<Collider>();

        // Assign the bouncy material to the Collider
        col.material = bouncyMaterial;
    }
}
