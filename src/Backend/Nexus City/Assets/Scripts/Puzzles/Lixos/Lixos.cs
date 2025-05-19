using UnityEngine;

public class LixoColetavel : MonoBehaviour
{
    public string tipoLixo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Obt�m o script PlayerInventario do jogador
            PlayerInventario inventario = other.GetComponent<PlayerInventario>();

            // Verifica se o invent�rio do jogador est� vazio (n�o tem lixo)
            if (inventario != null && string.IsNullOrEmpty(inventario.inventarioAtual))
            {
                // Coleta o lixo e adiciona ao invent�rio
                inventario.ColetarLixo(tipoLixo);

                // Aqui a destrui��o ocorre APENAS depois da coleta
                Debug.Log("Lixo coletado: " + tipoLixo);
                Destroy(gameObject); // Lixo desaparece ap�s ser coletado
            }
            else
            {
                Debug.Log("Voc� j� est� carregando um lixo ou n�o pode coletar este item.");
            }
        }
    }
}