using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider sliderVida;

    public void SetVidaMaxima (int vida) // Vida maxima
    {
        sliderVida.maxValue = vida; // vida maxima do slider � o int vida
        sliderVida.value = vida; // valor da vida � o int vida
    }

   public void SetVidaAtual(int vida) // Vida atual 
    {
        sliderVida.value = vida; // valor da vida � o int vida
    }
}



   