using UnityEngine;

public class PipesRotation : MonoBehaviour
{
    

    public void RotatePipe()
    {
        var Parent = transform.parent.gameObject; // cria variavel que pega o parent do objeto

        Parent.transform.Rotate(0, 0, 90); //rotaciona o parent do objeto

    }
}
