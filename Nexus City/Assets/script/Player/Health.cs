using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int vidaMaxima = 100;
    private int vidaAtual;

    public Slider sliderVida;

    void Start()
    {
        vidaAtual = vidaMaxima;
        sliderVida.maxValue = vidaMaxima;
        sliderVida.value = vidaAtual;
    }

    public void LevarDano(int dano)
    {
        vidaAtual -= dano;
        if (vidaAtual < 0) vidaAtual = 0;

        sliderVida.value = vidaAtual;

        if (vidaAtual <= 0)
        {
            Morrer();
        }
    }

    void Morrer()
    {
        Debug.Log("Morreu!");
        Time.timeScale = 0f;
        GameOverManager.instance.MostrarGameOver();
    }
}
