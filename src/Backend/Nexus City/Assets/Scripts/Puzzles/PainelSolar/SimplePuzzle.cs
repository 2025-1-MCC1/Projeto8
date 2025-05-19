using UnityEngine;
using UnityEngine.UI;

public class SimplePuzzle : MonoBehaviour
{
    public Button[] fios;
    public Button[] terminais;
    private int selectedFio = -1;
    private bool[] conectado = new bool[3];
    public Button finalizarBotao;

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

        finalizarBotao.onClick.AddListener(VerificarFinal);
    }

    void SelecionarFio(int index)
    {
        selectedFio = index;
    }

    void Conectar(int terminalIndex)
    {
        if (selectedFio == terminalIndex)
        {
            conectado[terminalIndex] = true;
            fios[selectedFio].interactable = false;
            terminais[terminalIndex].interactable = false;
            selectedFio = -1;
        }
    }

    void VerificarFinal()
    {
        if (conectado[0] && conectado[1] && conectado[2])
        {
            Debug.Log("Painel solar consertado!");
            gameObject.SetActive(false);
            Time.timeScale = 1f; // Volta o jogo ao normal
        }
        else
        {
            Debug.Log("Faltam conexões!");
        }
    }
}
