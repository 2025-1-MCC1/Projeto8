using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PausaTemporaria : MonoBehaviour
{
    public string tagDoJogador = "Player";
    public GameObject painelTexto; // Um painel de UI com o texto

    private bool jaAtivou = false;

    void OnTriggerEnter(Collider outro)
    {
        if (!jaAtivou && outro.CompareTag(tagDoJogador))
        {
            jaAtivou = true;
            StartCoroutine(PausarComTexto());
        }
    }

    IEnumerator PausarComTexto()
    {
        // Mostrar texto
        painelTexto.SetActive(true);

        // Pausar o tempo do jogo
        Time.timeScale = 0f;

        // Esperar 5 segundos em tempo real (independente do Time.timeScale)
        yield return new WaitForSecondsRealtime(5f);

        // Ocultar texto
        painelTexto.SetActive(false);

        // Voltar o tempo do jogo
        Time.timeScale = 1f;
    }
}
