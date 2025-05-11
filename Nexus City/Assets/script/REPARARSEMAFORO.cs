using UnityEngine;

public class TrafficLightRepair : MonoBehaviour
{
    public GameObject repairPoint;  // Ponto de intera��o (onde o jogador deve ir)
    public KeyCode repairKey = KeyCode.E; // Tecla para consertar
    public GameObject buttonUI;  // Refer�ncia ao bot�o que deve aparecer
    public TrafficLight trafficLightScript; // Refer�ncia ao script do sem�foro

    void Start()
    {
        // Esconde o bot�o inicialmente
        buttonUI.SetActive(false);
    }

    // Quando o jogador entra na �rea de intera��o
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Verifica se o objeto que entrou � o jogador
        {
            buttonUI.SetActive(true);  // Mostra o bot�o de intera��o
        }
    }

    // Quando o jogador sai da �rea de intera��o
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))  // Verifica se o objeto que saiu � o jogador
        {
            buttonUI.SetActive(false);  // Esconde o bot�o de intera��o
        }
    }

    // Fun��o para ser chamada quando o bot�o for clicado
    public void FixTrafficLight()
    {
        // Chama o m�todo de consertar o sem�foro
        trafficLightScript.FixSignal();
        Debug.Log("Sem�foro consertado!");

        // Desativa o bot�o ap�s o clique
        buttonUI.SetActive(false);  // Esconde o bot�o de intera��o
    }
}