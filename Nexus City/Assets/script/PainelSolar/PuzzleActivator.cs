using UnityEngine;

public class PuzzleActivator : MonoBehaviour
{
    public GameObject puzzleCanvas; // arraste aqui o Canvas do puzzle

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            puzzleCanvas.SetActive(true); // mostra o puzzle
            Time.timeScale = 0f; // pausa o jogo
        }
    }
}
