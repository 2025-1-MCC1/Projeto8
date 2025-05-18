using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private AudioClip waterBullet; //audio da bala de agua
    public GameObject bullet;
    private float lastBulletTime = 0;
    public float delayBetweenBullets = 1f;


  
    void Start()
    {
        InvokeRepeating("Shoot", 1f, 1f); // invoca os tiros repetidamente

    }
    void Update()
    {
        if (Time.time - lastBulletTime >= delayBetweenBullets)
        {
            AudioSource.PlayClipAtPoint(waterBullet, transform.position, 1f); // toca som da bala de agua
            lastBulletTime = Time.time; // atualiza tempo em que som da bala tocou
        }
    }
    void Shoot()
    {
        var Muzzle = gameObject.transform; // pega o transform do objeto

        Instantiate(bullet, Muzzle.position, Muzzle.rotation); // cria bala na mesma posição e rotação que o objeto
    }
}
