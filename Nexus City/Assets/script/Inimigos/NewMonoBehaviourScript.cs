using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject projetilPrefab;
    public Transform pontoDeDisparo;
    public float intervaloEntreDisparos = 2f;

    private float proximoDisparo;

    [SerializeField] private AudioClip tiro; //audio de tiro


    void Update()
    {
        if (Time.time >= proximoDisparo)
        {
            Disparar();
            proximoDisparo = Time.time + intervaloEntreDisparos;
        }
    }

    void Disparar()
    {
        Instantiate(projetilPrefab, pontoDeDisparo.position, pontoDeDisparo.rotation);
        AudioSource.PlayClipAtPoint(tiro, transform.position, 1f); // toca som de tiro
    }
}