using UnityEngine;
using UnityEngine.SceneManagement;

public class ProximaFase: MonoBehaviour
{

    
    // Nome da próxima cena que será carregada
    public string ProximaFase1;

    private void OnTriggerEnter(Collider collider)
    {
        // Quando algum objeto entra no trigger, carrega a próxima fase
        SceneManager.LoadScene(ProximaFase1);
        

    }
}