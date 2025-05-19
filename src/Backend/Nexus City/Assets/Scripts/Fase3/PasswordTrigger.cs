using UnityEngine;

public class PasswordTrigger : MonoBehaviour
{
    public GameObject passwordPanel;
    public MonoBehaviour playerController; // referência ao controlador do jogador
    [SerializeField] private AudioClip puzzleAtivado; //audio de ativação do puzzle


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            passwordPanel.SetActive(true);
            AudioSource.PlayClipAtPoint(puzzleAtivado, transform.position, 1f); // toca som ativação de puzzle
            // Desativa o movimento do jogador enquanto ele resolve o puzzle
            if (playerController != null)
            {
                playerController.enabled = false; // desativa o movimento
            }
        }
    }

    // Método para destruir o trigger (quando a senha for resolvida)
    public void DestroyTrigger()
    {
        Destroy(gameObject);
    }
}
