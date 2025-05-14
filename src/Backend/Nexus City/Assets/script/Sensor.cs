using UnityEngine;

public class SensorDeLixo : MonoBehaviour
{
    public GameObject caminhao;
    private bool ativado = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !ativado)
        {
            ativado = true;
            caminhao.SetActive(true);
            Debug.Log("Sensor ativado! Caminhão de lixo a caminho.");
        }
    }
}