using UnityEngine;
using static UnityEditor.ShaderData;

public class TriggerCanos1 : MonoBehaviour
{
    [SerializeField] private AudioClip puzzleAtivo; //audio de ativação do puzzle
    public GameObject PuzzleCanos1; // canvas do puzzle
    public GameObject Canvas1; // texto que pede input do jogador
    public GameObject Win1; // canvas de quando jogador ganha

    private bool PlayerTrigger = false;
    private AudioSource audioSource;

    void Start()
    {
        PuzzleCanos1.gameObject.SetActive(false); //desativa o canvas do puzzle
        Canvas1.gameObject.SetActive(false); // desativa o texto de input
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && PlayerTrigger) //se o player estiver dentro do trigger e apertar "E"...
        {
            AudioSource.PlayClipAtPoint(puzzleAtivo, transform.position, 1f); // toca som da ativação de puzzles
            Canvas1.SetActive(false); // desativa canvas1 
            PuzzleCanos1.SetActive(true); //ativa canvas do puzzle
            Win1.SetActive(false);// desativa canvas de vitoria
            Time.timeScale = 0f; // pausa o tempo
           

        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player") //se player entrar no trigger
        {
            Canvas1.SetActive(true); // ativa o texto de input
            PlayerTrigger = true; // faz com que PlayerTrigger seja true
        }

       

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player") //se player sair do trigger
        {
            Canvas1.SetActive(false); //desativa texto de input
            PlayerTrigger = false; // faz com que Playertrigger seja false
        }
    }
}
