
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
        transform.Translate(0.01f, 0, 0); // anda para frente

    }

    private void OnCollisionEnter(Collision collision) // colis�o
    {
        if ((collision.gameObject.tag == "Barrier") | (collision.gameObject.name == "Player")) //verifica colis�o com a barreira e com o player
        {
            transform.Rotate(0, 180, 0); //vira o inimigo
            Start();
        }


    }
}

