using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // o personagem
    public Vector3 offset;   // dist�ncia da c�mera pro personagem
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        if (target != null)
        {
            // Define a nova posi��o da c�mera com o offset
            Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z) + offset;

            // Suaviza o movimento
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            transform.position = smoothedPosition;
        }
    }
}