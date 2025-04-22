using UnityEngine;
using UnityEngine.SceneManagement;

public class PassouDeFase : MonoBehaviour
{
    // Nome da pr�xima cena que ser� carregada
    public string ProximaFase;

    private void OnTriggerEnter(Collider collider)
    {
        // Quando algum objeto entra no trigger, carrega a pr�xima fase
        SceneManager.LoadScene(ProximaFase);
    }
}

