using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public static GameOverManager instance;
    public GameObject telaGameOver;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void MostrarGameOver()
    {
        telaGameOver.SetActive(true);
    }

    public void ReiniciarJogo()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}