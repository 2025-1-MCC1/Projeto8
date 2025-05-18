using UnityEngine;

public class PipesRotation : MonoBehaviour
{
    

    public void RotatePipe()
    {
        var Parent = transform.parent.gameObject;

        Parent.transform.Rotate(0, 0, 90);

    }
}
