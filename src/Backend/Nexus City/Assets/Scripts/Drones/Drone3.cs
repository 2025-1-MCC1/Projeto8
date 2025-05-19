using UnityEngine;

public class Drone3 : MonoBehaviour
{
    public float speed = 2f;
    public float height = 1f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float x = Mathf.Sin(Time.time * speed) * height;
        transform.position = startPos + new Vector3(x, 0, 0); // Movimento de um lado para o outro
    }
}
