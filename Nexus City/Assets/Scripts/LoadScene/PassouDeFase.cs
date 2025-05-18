using UnityEngine;
using UnityEngine.SceneManagement;

public class PassouDeFase : MonoBehaviour
{
    // Nome da próxima cena que será carregada
    public string ProximaFase;

    private void OnTriggerEnter(Collider collider)
    {
        // Quando algum objeto entra no trigger, carrega a próxima fase
        SceneManager.LoadScene(ProximaFase);
    }
}

