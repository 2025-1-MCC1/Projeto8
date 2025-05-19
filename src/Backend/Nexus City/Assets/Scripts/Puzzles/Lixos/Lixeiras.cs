using UnityEngine;

public class Lixeira : MonoBehaviour
{
    public string tipoAceito; // Ex: "Org�nico", "Recicl�vel", "Eletr�nico"

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
                Debug.Log("O jogador n�o tem lixo no invent�rio.");
            }
        }
    }
}