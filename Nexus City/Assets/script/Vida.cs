using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Vida : MonoBehaviour
{
    public int vidaMaxima = 100;
    private int vidaAtual;

    public int danoRecebido = 100;
    public Slider barraDeVida;

    public GameObject painelGameOver; // Referência para o painel de Game Over

    void Start()
    {
        vidaAtual = vidaMaxima;
        AtualizarBarraDeVida();
        if (painelGameOver != null)
            painelGameOver.SetActive(false); // Garante que comece desativado
    }

    private void OnTriggerEnter(Collider outro)
    {
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
        if (painelGameOver != null)
            painelGameOver.SetActive(true);

        // Você pode também pausar o tempo do jogo se quiser:
        // Time.timeScale = 0;
    }

    // Essa função será chamada pelo botão "Tentar Novamente"
    public void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // Se tiver pausado o tempo, ative de novo:
        // Time.timeScale = 1;
    }

    internal void TakeDamage(int damageAmount)
    {
        throw new NotImplementedException();
    }
}