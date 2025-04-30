using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*public class Vida : MonoBehaviour
{
    public int vidaMaxima = 100;
    private int vidaAtual;

    public int danoRecebido = 100;
    public Slider barraDeVida;
    public GameObject painelGameOver;

    void Start()
    {
        vidaAtual = vidaMaxima;
        AtualizarBarraDeVida();

        // Oculta o painel de Game Over no início do jogo
        if (painelGameOver != null)
            painelGameOver.SetActive(false);
    }

    private void OnTriggerEnter(Collider outro)
    {
        // Verifica se o objeto que colidiu tem a tag "Dano"
        if (outro.CompareTag("Dano"))
        {
            LevarDano(danoRecebido);
        }
    }

    public void LevarDano(int quantidade)
    {
        vidaAtual -= quantidade;
        vidaAtual = Mathf.Clamp(vidaAtual, 0, vidaMaxima);
        AtualizarBarraDeVida();

        Debug.Log("Levou dano! Vida atual: " + vidaAtual);

        if (vidaAtual <= 0)
        {
            Morrer();
        }
    }

    void AtualizarBarraDeVida()
    {
        if (barraDeVida != null)
        {
            barraDeVida.value = (float)vidaAtual / vidaMaxima;
        }
    }

    void Morrer()
    {
        Debug.Log("O personagem morreu!");

        // Exibe o painel de Game Over
        if (painelGameOver != null)
            painelGameOver.SetActive(true);

        // Opcional: pausar o jogo
        // Time.timeScale = 0;
    }

    public void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // Opcional: retomar o tempo se estiver pausado
        // Time.timeScale = 1;
    }
}*/



