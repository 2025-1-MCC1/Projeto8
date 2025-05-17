using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject projetilPrefab;
    public Transform pontoDeDisparo;
    public float intervaloEntreDisparos = 2f;

    private float proximoDisparo;

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
    }
}