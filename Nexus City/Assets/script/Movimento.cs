using Unity.VisualScripting;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public  CharacterController character;
    private Animator animator;
    private Vector2 input;

    private float velocidade = 4f;
    private float forcaY;
    private bool podePular = true;

    public bool estaNoChao;
    [SerializeField] private LayerMask colisaoLayer;
    [SerializeField] public Transform peDoPersonagem;

    private float gravidade = -20f;
    private float forcaPulo = 10f;

    void Start()
    {
        character = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Movimento lateral no eixo X (2.5D)
        input.Set(Input.GetAxisRaw("Horizontal"), 0);

        Vector3 move = new Vector3(input.x * velocidade, 0, 0);

        // Verifica se está no chão
        estaNoChao = Physics.CheckSphere(peDoPersonagem.position, 0.2f, colisaoLayer);
        animator.SetBool("estatNoChao", estaNoChao);

        if (estaNoChao && forcaY < 0)
        {
            forcaY = -2f;
            podePular = true;
        }

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao && podePular)
        {
            forcaY = forcaPulo;
            animator.SetTrigger("pular");
            podePular = false;
        }

        // Gravidade
        forcaY += gravidade * Time.deltaTime;
        move.y = forcaY;

        // Move personagem
        character.Move(move * Time.deltaTime);

        // Espelha o personagem na direção correta (lado)
        if (input.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);  // Direita
        }
        else if (input.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0); // Esquerda
        }

        // Animação de corrida
        if (Mathf.Abs(input.x) > 0.1f)
        {
            animator.SetBool("correndo", true);
        }
        else
        {
            animator.SetBool("correndo", false);
        }

        
    }
    
    
    
}
        
   