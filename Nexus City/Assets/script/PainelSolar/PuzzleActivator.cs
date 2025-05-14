using UnityEngine;

public class PuzzleActivator : MonoBehaviour
{
    public GameObject puzzleCanvas; // Arraste aqui o Canvas do puzzle

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entrou no trigger!"); // Mensagem de teste
            puzzleCanvas.SetActive(true); // Mostra o puzzle
            Time.timeScale = 0f; // Pausa o jogo
        }
    }
}
