using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    [Header("Target Settings")]
    public Transform target;                // The target to follow

    [Header("Follow Settings")]
    public float followSpeed = 5f;          // The speed of following (higher values make it follow more quickly)
    public Vector3 offset = Vector3.zero;   // Offset from the target position

    void Update()
    {
        if (target != null)
        {
            // Calculate the target position with offset
            Vector3 targetPosition = target.position + offset;
            
            // Smoothly interpolate the position from current to target
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }
}

