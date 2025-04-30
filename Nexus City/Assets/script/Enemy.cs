
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.05f, 0, 0);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Barrier") | (collision.gameObject.name == "Player"))
        {
            transform.Rotate(0, 180, 0);
            Start();
        }


    }
}

