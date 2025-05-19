using Unity.VisualScripting;
using UnityEngine;

public class Projectile3D : MonoBehaviour
{
    public float velocidade = 7f;
    [SerializeField] private AudioClip impacto; //audio de impacto

    void Update()
    {
        // Move no eixo X (ou Z dependendo do seu cenário)
        transform.Translate(Vector3.right * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(impacto, transform.position, 1f); // toca som de impacto
            other.GetComponent<PlayerHealth>()?.LevarDano(10);
            Destroy(gameObject);
        }

        if (!other.CompareTag("Enemy"))
        {
            AudioSource.PlayClipAtPoint(impacto, transform.position, 1f); // toca som de impacto
            Destroy(gameObject);
        }
    }
    }