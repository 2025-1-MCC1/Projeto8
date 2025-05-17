using UnityEngine;
using UnityEngine.SceneManagement;

public class Inimigo : MonoBehaviour
{
    void OnTriggerEnter(Collider outro)
    {
        if (outro.CompareTag("Player"))
        {
            Morrer();
        }
    }

    void Morrer()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Fim"); // <-- Substitua pelo nome da cena correta
    }
}