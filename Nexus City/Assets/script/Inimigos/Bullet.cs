using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject IgnoreEnemy;
    float speed = 10;


    void Start()
    {
        Destroy(gameObject, 4f); //destroi a bala após 7 segundos
    }


    void Update()
    {
        transform.Translate(transform.right * speed * Time.deltaTime); // faz a bala ir para frente 
        Start();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);  //deleta a bala quando ela atinge algo
    }
}
