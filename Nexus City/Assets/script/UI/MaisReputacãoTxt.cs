using UnityEngine;
using System.Collections;

public class MaisReputacãoTxt : MonoBehaviour
{

    void Update()
    {
        if (gameObject.activeSelf) //se o objeto estiver ativo
        {
            StartCoroutine(wait()); //começa coroutine
        }
        
    }


    public IEnumerator wait()
    {
        yield return new WaitForSeconds(2f); // espera 2 segundos
        gameObject.SetActive(false); // se desativa

    }
}
