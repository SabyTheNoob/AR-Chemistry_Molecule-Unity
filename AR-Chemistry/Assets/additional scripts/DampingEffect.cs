using UnityEngine;

public class DampingEffect : MonoBehaviour
{[Header("Damping Settings")]
    public float positionDamping = 5f;   // Higher values make it follow more quickly
    public float rotationDamping = 5f;   // Higher values make it follow more quickly

    private Vector3 velocity = Vector3.zero;
    private Quaternion targetRotation;
    private Transform parentTransform;

    void Start()
    {
        parentTransform = transform.parent;
        targetRotation = transform.rotation;  // Keep the initial rotation
    }

    void Update()
    {
        // Smoothly move to parent’s position with damping
        Vector3 targetPosition = parentTransform.position + parentTransform.TransformDirection(Vector3.zero);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, positionDamping * Time.deltaTime);

        // Smoothly rotate to follow parent’s rotation with damping
        targetRotation = Quaternion.Slerp(transform.rotation, parentTransform.rotation, rotationDamping * Time.deltaTime);
        transform.rotation = targetRotation;
    }

}
