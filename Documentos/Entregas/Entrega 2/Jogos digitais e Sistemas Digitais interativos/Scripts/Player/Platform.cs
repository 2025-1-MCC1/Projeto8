using UnityEngine;

public class Platform : MonoBehaviour
{



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) // colisao ao entrar no trigger
    {
        if (other.gameObject.tag == "Plataforma") // se colidir com plataforma
        {
            transform.SetParent(other.transform); // faz com que a plataforma seja o parent do objeto
        }
    }

    private void OnTriggerExit(Collider other) // colisao ao sair do trigger
    {
        if (other.gameObject.tag == "Plataforma") // se sair da colisao com a plataforma
        {
            transform.SetParent(null); // faz com que o objeto não tenha mais parent
        }
    }
}
