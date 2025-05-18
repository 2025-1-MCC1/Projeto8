using UnityEngine;
using System.Collections;

public class MaisReputacãoTxt : MonoBehaviour
{

    void Update()
    {
        if (gameObject.activeSelf)
        {
            StartCoroutine(wait());
        }
        
    }


    public IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);

    }
}
