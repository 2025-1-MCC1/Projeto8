using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MorteDoPersonagem : MonoBehaviour
{
    public GameObject painelGameOver; // Painel com o botão "Iniciar"
    private Movimento movimento; // Referência ao script de movimento
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
            painelGameOver.SetActive(true); // Mostra o botão
            Debug.Log("Morreu!");
        }
    }

    // Essa função será chamada pelo botão
    public void ReiniciarCena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}