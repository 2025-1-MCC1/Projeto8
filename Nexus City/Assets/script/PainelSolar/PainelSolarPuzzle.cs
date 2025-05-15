using UnityEngine;
using UnityEngine.UI;

public class PainelSolarPuzzle : MonoBehaviour
{
    public Button[] fios; // 3 fios
    public Button[] terminais; // 3 terminais
    public Button botaoConcluir;
    public Button botaoSair;     // Botão para sair do puzzle

    private int fioSelecionado = -1;
    private bool[] conectado = new bool[3];

    void Start()
    {
        for (int i = 0; i < fios.Length; i++)
        {
            int index = i;
            fios[i].onClick.AddListener(() => SelecionarFio(index));
        }

        for (int i = 0; i < terminais.Length; i++)
        {
            int index = i;
            terminais[i].onClick.AddListener(() => Conectar(index));
        }

        botaoConcluir.onClick.AddListener(FinalizarPuzzle);

        botaoSair.onClick.AddListener(SairDoPuzzle);
    }

    void SelecionarFio(int index)
    {
        fioSelecionado = index;
        Debug.Log("Fio selecionado: " + index);
    }

    void Conectar(int terminalIndex)
    {
        if (fioSelecionado == -1)
        {
            Debug.Log("Selecione um fio primeiro!");
            return;
        }

        if (fioSelecionado == terminalIndex)
        {
            Debug.Log("Conectado corretamente!");
            fios[fioSelecionado].interactable = false;
            terminais[terminalIndex].interactable = false;
            conectado[terminalIndex] = true;
        }
        else
        {
            Debug.Log("Conexão errada!");
        }

        fioSelecionado = -1;
    }

    void FinalizarPuzzle()
    {
        if (conectado[0] && conectado[1] && conectado[2])
        {
            Debug.Log("Puzzle resolvido!");
            gameObject.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            Debug.Log("Ainda falta ligar algum fio!");
        }
    }
    void SairDoPuzzle()
    {
        Debug.Log("Saindo do puzzle...");

        // Aqui você pode decidir o que fazer quando o jogador sair do puzzle:
        // 1. Desativa o painel do puzzle.
        // 2. Retorna para o menu principal ou cena anterior.

        gameObject.SetActive(false); // Desativa o painel do puzzle
        Time.timeScale = 1f; // Se o jogo foi pausado, retoma o tempo normal
    }
}

