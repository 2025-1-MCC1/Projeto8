using UnityEngine;

public class Lixeira : MonoBehaviour
{
    public string tipoAceito;
    public bool lixoEntregue = false; // Isso j� impede mais de uma entrega

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o Player est� colidindo com a lixeira
        if (other.CompareTag("Player") && !lixoEntregue)
        {
            PlayerInventario inventario = other.GetComponent<PlayerInventario>();

            if (inventario != null && !string.IsNullOrEmpty(inventario.inventarioAtual))
            {
                // Verifica se o lixo do player � o aceito pela lixeira
                if (inventario.inventarioAtual == tipoAceito)
                {
                    Debug.Log(" Lixo correto entregue: " + inventario.inventarioAtual);
                    inventario.LimparInventario(); // Limpa o invent�rio do player
                    lixoEntregue = true; // Marca que o lixo j� foi entregue, para n�o permitir nova entrega
                }
                else
                {
                    Debug.Log(" Lixo errado: " + inventario.inventarioAtual + ". Aceita: " + tipoAceito);
                }
            }
            else
            {
                Debug.Log(" O jogador n�o tem lixo no invent�rio.");
            }
        }
    }
}