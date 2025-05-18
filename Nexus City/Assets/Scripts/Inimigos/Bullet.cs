using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject IgnoreEnemy;
    float speed = 10;

    [SerializeField] private AudioClip waterSplash; //audio da bala da agua colidindo om algo

    void Start()
    {
        Destroy(gameObject, 1f); //destroi a bala após 4 segundos
    }


    void Update()
    {
        transform.Translate(transform.right * speed * Time.deltaTime); // faz a bala ir para frente 
        Start();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);  //deleta a bala quando ela atinge algo
        AudioSource.PlayClipAtPoint(waterSplash, transform.position, 0.5f); // toca som da bala batendo em algo
    }
}
