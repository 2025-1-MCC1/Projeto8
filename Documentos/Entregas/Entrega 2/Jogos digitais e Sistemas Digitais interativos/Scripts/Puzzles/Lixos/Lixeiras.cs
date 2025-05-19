using UnityEngine;

public class Lixeira : MonoBehaviour
{
    public string tipoAceito; // Ex: "Orgânico", "Reciclável", "Eletrônico"

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventario inventario = other.GetComponent<PlayerInventario>();

            if (inventario != null && !string.IsNullOrEmpty(inventario.inventarioAtual))
            {
                if (inventario.inventarioAtual == tipoAceito)
                {
                    Debug.Log("Lixo correto entregue: " + inventario.inventarioAtual);
                    inventario.LimparInventario(); // Remove o lixo do jogador
                  
                }
                else
                {
                    Debug.Log("Lixo errado: " + inventario.inventarioAtual + ". Aceita: " + tipoAceito);
                }
            }
            else
            {
                Debug.Log("O jogador não tem lixo no inventário.");
            }
        }
    }
}