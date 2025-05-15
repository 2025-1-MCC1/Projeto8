using UnityEngine;

public class PasswordTrigger : MonoBehaviour
{
    public GameObject passwordPanel;
    public MonoBehaviour playerController; // refer�ncia ao controlador do jogador


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            passwordPanel.SetActive(true);

            // Desativa o movimento do jogador enquanto ele resolve o puzzle
            if (playerController != null)
            {
                playerController.enabled = false; // desativa o movimento
            }
        }
    }

    // M�todo para destruir o trigger (quando a senha for resolvida)
    public void DestroyTrigger()
    {
        Destroy(gameObject);
    }
}
