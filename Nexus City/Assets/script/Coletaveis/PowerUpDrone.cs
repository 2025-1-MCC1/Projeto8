using UnityEngine;
using TMPro;
using UnityEngine.UI; // Para acessar o Slider

public class PowerUpDrone : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI mensagemTMP;
    [SerializeField] private Slider barraReputacao; // Arraste sua barra aqui
    [SerializeField] private float tempoExibicao = 3f;
    [SerializeField] private float aumentoReputacao = 10f; // Quanto vai aumentar
    [SerializeField] private AudioClip reputacao; //audio de reputacao


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mensagemTMP.text = "+ Drones!";

            // Aumenta a barra de reputação
            barraReputacao.value = Mathf.Clamp(barraReputacao.value + aumentoReputacao, 0, barraReputacao.maxValue);

            Invoke(nameof(OcultarMensagem), tempoExibicao);
            gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(reputacao, transform.position, 1f); // toca som de reputacao
        }
    }

    private void OcultarMensagem()
    {
        mensagemTMP.text = "";
    }
}