using UnityEngine;

public class DroneFollower : MonoBehaviour
{
    private Movimento movimentoScript; // Seu script de movimento
    private Transform droneEmbaixo;
    private Vector3 ultimoDronePos;

    void Start()
    {
        movimentoScript = GetComponent<Movimento>();
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("Drone"))
        {
            // Verifica se colidiu com a parte de cima do drone
            if (Vector3.Dot(hit.normal, Vector3.up) > 0.5f)
            {
                droneEmbaixo = hit.collider.transform;
                ultimoDronePos = droneEmbaixo.position;
            }
        }
    }

    void Update()
    {
        if (droneEmbaixo != null)
        {
            // Calcula o quanto o drone se moveu
            Vector3 deltaDrone = droneEmbaixo.position - ultimoDronePos;
            // Move o personagem junto
            movimentoScript.character.Move(deltaDrone);

            // Atualiza a última posição
            ultimoDronePos = droneEmbaixo.position;

            // Se o personagem sair do drone (não estiver mais tocando), limpar
            if (!movimentoScript.estaNoChao || !Physics.CheckSphere(movimentoScript.peDoPersonagem.position, 0.2f, LayerMask.GetMask("Drone")))
            {
                droneEmbaixo = null;
            }
        }
    }
}