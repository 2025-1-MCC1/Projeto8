using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 5f;
    public float destroyAfter = 10f;

    void Start()
    {
        Destroy(gameObject, destroyAfter);
    }

    void Update()
    {
        if (TrafficLight.isGreen)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}