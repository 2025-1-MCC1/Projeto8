using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private AudioClip maisVida; //audio de + vida
    public int vidaAtual; // qual é a vida minima
    public int vidaMaxima = 100; //qual é a vida maxima
    public GameObject hotDog; //hot dog
    public GameObject painelGameOver; // Painel gameover
    private Movimento movimento; // Referência ao script de movimento

    public HealthBar healthBar;

    
    void Start()
    {
        vidaAtual = vidaMaxima; //vida atual no começo da fase é igual a vida maxima
        healthBar.SetVidaMaxima(vidaMaxima); //atualiza barra de vida 

        movimento = GetComponent<Movimento>(); //pega movimento do personagem
        painelGameOver.SetActive(false); //desativa tela de gameover
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dano10") //se colide com coisas que dão 10 de dano
        {
            TomarDano(10); //chama tomar dano e coloca 10 na int dano
        }

        if (collision.gameObject.tag == "Dano5") //se colide com coisas que dão 5 de dano
        {
            TomarDano(5); //chama tomar dano e coloca 5 na int dano
        }

        
    }

    private void OnTriggerEnter(Collider other) //quando entrar em um trigger
    {
        if (other.gameObject.tag == "Comida") //se for comida..
        {
            RecuperarVida(30); //chama recuperar vida e coloca 30 na int recuperar
            hotDog.SetActive(false);
            
        }
    }
    void TomarDano(int dano) // quando dano é tomado
    {

        vidaAtual -= dano; //diminui a vida
        Debug.Log("Dano"); 
        healthBar.SetVidaAtual(vidaAtual); //atualiza barra de vida

        if (vidaAtual <= 0)
        {
            movimento.enabled = false; // Desativa o controle do personagem
            painelGameOver.SetActive(true); // mostra o canvas de gameover
        }

        
    }

    void RecuperarVida(int recuperar) // quando a vida é recuperada
    {

        vidaAtual += recuperar; // adiciona vida
        Debug.Log("+Vida"); 
        healthBar.SetVidaAtual(vidaAtual); //atualiza barra de vida
        AudioSource.PlayClipAtPoint(maisVida, transform.position, 1f); // toca som de + vida


    }

}



