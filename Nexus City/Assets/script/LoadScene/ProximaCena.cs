using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    // M�todo chamado quando o bot�o "Continuar" � pressionado
    public void OnContinuePressed()
    {
        // Pega o �ndice da cena atual
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Carrega a pr�xima cena com base no �ndice atual
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}