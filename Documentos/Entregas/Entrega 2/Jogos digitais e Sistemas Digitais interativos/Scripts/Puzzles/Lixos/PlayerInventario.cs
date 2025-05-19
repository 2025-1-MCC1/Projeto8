using UnityEngine;

public class PlayerInventario : MonoBehaviour
{
    public string inventarioAtual;

    public void ColetarLixo(string tipo)
    {
        inventarioAtual = tipo;
        Debug.Log("Coletou: " + tipo);
    }

    public void LimparInventario()
    {
        inventarioAtual = null;
    }
}