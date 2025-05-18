using UnityEngine;
using TMPro;
using System.Collections;

public class PasswordChallenge : MonoBehaviour
{
    [Header("Senha correta")]
    public string correctPassword = "123456";

    [Header("Referências da UI TMP")]
    public TMP_InputField inputField;
    public TMP_Text messageText;
    public GameObject passwordPanel;

    [Header("Referência ao controlador do jogador")]
    public MonoBehaviour playerController; // referência ao script de movimento do jogador

    [Header("Trigger a ser destruído")]
    public PasswordTrigger triggerScript; // referência ao script do trigger

    [SerializeField] private AudioClip win; //audio de vitoria do puzzle
    [SerializeField] private AudioClip puzzleDesativo; //audio de desativação do puzzle



    public void CheckPassword()
    {
        string entered = inputField.text.Trim();

        Debug.Log("Digitado: '" + entered + "'");

        if (entered == correctPassword)
        {
            messageText.text = "Desafio concluído!";
            messageText.color = Color.green;
            AudioSource.PlayClipAtPoint(win, transform.position, 1f); // toca som de vitoria
            StartCoroutine(HidePanelAfterDelay(2f)); // espera 2 segundos
            OnPasswordCorrect();
        }
        else
        {
            messageText.text = "Senha incorreta!";
            messageText.color = Color.red;
        }
    }

    void OnPasswordCorrect()
    {
        Debug.Log("Senha correta! Pode seguir o jogo.");

        // Destrói o trigger após resolver o desafio
        if (triggerScript != null)
        {
            triggerScript.DestroyTrigger();
        }

        // Reativa o movimento do jogador
        if (playerController != null)
        {
            playerController.enabled = true;
        }

    }

    IEnumerator HidePanelAfterDelay(float delay)
    {
        AudioSource.PlayClipAtPoint(puzzleDesativo, transform.position, 1f); // toca som de desativar puzzle

        yield return new WaitForSeconds(delay);
        passwordPanel.SetActive(false);
    }
}
