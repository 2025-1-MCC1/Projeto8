using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MorteDoPersonagem : MonoBehaviour
{
    public GameObject painelGameOver; // Painel com o bot�o "Iniciar"
    private Movimento movimento; // Refer�ncia ao script de movimento
    private bool morreu = false;

    void Start()
    {
        movimento = GetComponent<Movimento>();
        painelGameOver.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Danger") && !morreu)
        {
            morreu = true;
            movimento.enabled = false; // Desativa o controle do personagem
            painelGameOver.SetActive(true); // Mostra o bot�o
            Debug.Log("Morreu!");
        }
    }

    // Essa fun��o ser� chamada pelo bot�o
    public void ReiniciarCena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}