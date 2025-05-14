using UnityEngine;

public class LixoColetavel : MonoBehaviour
{
    public string tipoLixo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Obtém o script PlayerInventario do jogador
            PlayerInventario inventario = other.GetComponent<PlayerInventario>();

            // Verifica se o inventário do jogador está vazio (não tem lixo)
            if (inventario != null && string.IsNullOrEmpty(inventario.inventarioAtual))
            {
                // Coleta o lixo e adiciona ao inventário
                inventario.ColetarLixo(tipoLixo);

                // Aqui a destruição ocorre APENAS depois da coleta
                Debug.Log("Lixo coletado: " + tipoLixo);
                Destroy(gameObject); // Lixo desaparece após ser coletado
            }
            else
            {
                Debug.Log("Você já está carregando um lixo ou não pode coletar este item.");
            }
        }
    }
}