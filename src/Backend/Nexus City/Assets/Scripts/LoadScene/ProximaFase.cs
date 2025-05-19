using UnityEngine;
using UnityEngine.SceneManagement;

public class ProximaFase: MonoBehaviour
{

    
    // Nome da pr�xima cena que ser� carregada
    public string ProximaFase1;

    private void OnTriggerEnter(Collider collider)
    {
        // Quando algum objeto entra no trigger, carrega a pr�xima fase
        SceneManager.LoadScene(ProximaFase1);
        

    }
}