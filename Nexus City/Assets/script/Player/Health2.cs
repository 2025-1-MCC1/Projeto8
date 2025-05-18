using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    public int vidaAtual;
    public int vidaMaxima = 100;
    public GameObject hotDog;

    public HealthBar healthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidaAtual = vidaMaxima;
        healthBar.SetVidaMaxima(vidaMaxima);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dano10")
        {
            TomarDano(10);
        }

        if (collision.gameObject.tag == "Dano5")
        {
            TomarDano(5);
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Comida")
        {
            RecuperarVida(30);
            hotDog.SetActive(false);
        }
    }
    void TomarDano(int dano)
    {

        vidaAtual -= dano;
        Debug.Log("Dano");
        healthBar.SetVidaAtual(vidaAtual);

        if (vidaAtual <= 0)
        {
            SceneManager.LoadScene(7);
        }

        
    }

    void RecuperarVida(int recuperar)
    {

        vidaAtual += recuperar;
        Debug.Log("+Vida");
        healthBar.SetVidaAtual(vidaAtual);



    }

}



