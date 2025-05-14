using UnityEngine;

public class TrafficLightRepair : MonoBehaviour
{
    public GameObject repairPoint;  // Ponto de interação (onde o jogador deve ir)
    public KeyCode repairKey = KeyCode.E; // Tecla para consertar
    public GameObject buttonUI;  // Referência ao botão que deve aparecer
    public TrafficLight trafficLightScript; // Referência ao script do semáforo

    void Start()
    {
        // Esconde o botão inicialmente
        buttonUI.SetActive(false);
    }

    // Quando o jogador entra na área de interação
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Verifica se o objeto que entrou é o jogador
        {
            buttonUI.SetActive(true);  // Mostra o botão de interação
        }
    }

    // Quando o jogador sai da área de interação
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))  // Verifica se o objeto que saiu é o jogador
        {
            buttonUI.SetActive(false);  // Esconde o botão de interação
        }
    }

    // Função para ser chamada quando o botão for clicado
    public void FixTrafficLight()
    {
        // Chama o método de consertar o semáforo
        trafficLightScript.FixSignal();
        Debug.Log("Semáforo consertado!");

        // Desativa o botão após o clique
        buttonUI.SetActive(false);  // Esconde o botão de interação
    }
}