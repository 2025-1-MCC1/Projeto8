using UnityEngine;

public class Projectile3D : MonoBehaviour
{
    public float velocidade = 7f;

    void Update()
    {
        // Move no eixo X (ou Z dependendo do seu cenário)
        transform.Translate(Vector3.right * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>()?.LevarDano(10);
            Destroy(gameObject);
        }

        if (!other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
    }