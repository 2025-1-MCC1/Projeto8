using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider sliderVida;

    public void SetVidaMaxima (int vida)
    {
        sliderVida.maxValue = vida;
        sliderVida.value = vida;
    }

   public void SetVidaAtual(int vida)
    {
        sliderVida.value = vida;
    }
}



   