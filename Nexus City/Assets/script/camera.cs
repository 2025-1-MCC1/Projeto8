using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // o personagem
    public Vector3 offset;   // distância da câmera pro personagem
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        if (target != null)
        {
            // Define a nova posição da câmera com o offset
            Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z) + offset;

            // Suaviza o movimento
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            transform.position = smoothedPosition;
        }
    }
}