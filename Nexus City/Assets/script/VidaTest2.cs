using TMPro;
using UnityEngine;

public class VidaTest2 : MonoBehaviour
{

    private int vidaAtual = 50;
    public int danoRecebido = 10;
    public TMP_Text vidaTesteTxt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidaTesteTxt.text = vidaAtual.ToString();
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dano")
        {
            vidaAtual = vidaAtual - danoRecebido;
        }
    }


}
