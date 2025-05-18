using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    // Método chamado quando o botão "Continuar" é pressionado
    public void OnContinuePressed()
    {
        // Pega o índice da cena atual
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Carrega a próxima cena com base no índice atual
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}