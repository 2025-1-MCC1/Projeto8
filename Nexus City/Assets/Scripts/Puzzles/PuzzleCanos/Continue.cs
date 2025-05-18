using UnityEngine;
using UnityEngine.UI;



public class Continue : MonoBehaviour
{
    [SerializeField] private AudioClip puzzleDesativo; //audio de desativa��o do puzzle
    public GameObject muzzle; //ponta do hidrante
    public GameObject triggerBox; //trigger do puzzle
    public GameObject canvasPuzzle; //canvas do puzzle
    public GameObject maisReputacao; //texto "+ Reputa��o"
    public GameObject icone; // icone de puzzle
    private float aumentoReputacao = 10f; // o quanto a reputa��o aumenta
    public Slider barraReputacao; // slider da reputa��o
    private AudioSource audioSource;
    public void ContinueBnt() // bat�o de continue
    {
        var stopbullets = muzzle.GetComponent<Turret>(); //pega o script turret do muzzle


        stopbullets.CancelInvoke(); // cancela o invoke das balas do hidrante
        Time.timeScale = 1f; //volta o tempo ao normal
        barraReputacao.value = Mathf.Clamp(barraReputacao.value + aumentoReputacao, 0, barraReputacao.maxValue); //aumenta a barra da reputa��o
        
        AudioSource.PlayClipAtPoint(puzzleDesativo, transform.position, 1f); // toca som da desativa��o de puzzles
        
        icone.SetActive(false); //desativa icone
        canvasPuzzle.SetActive(false); //desativa canvas do puzzle
        triggerBox.SetActive(false); //desativa trigger do puzzle
        maisReputacao.SetActive(true); // ativa texto da reputa��o

        muzzle.SetActive(false);

    }
    
}
