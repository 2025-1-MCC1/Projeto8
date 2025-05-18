using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PausaTemporaria : MonoBehaviour
{
    public string tagDoJogador = "Player";
    public GameObject painelTexto; // Um painel de UI com o texto

    [SerializeField] private AudioClip abrir; //audio de abrir
    [SerializeField] private AudioClip fechar; //audio de fechar


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

        AudioSource.PlayClipAtPoint(abrir, transform.position, 1f); // toca o de som Abrir

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

        AudioSource.PlayClipAtPoint(fechar, transform.position, 1f); // toca o de som fechar
    }
}
