using UnityEngine;
using UnityEngine.UI;



public class Continue : MonoBehaviour
{

    public GameObject muzzle; //ponta do hidrante
    public GameObject triggerBox; //trigger do puzzle
    public GameObject canvasPuzzle; //canvas do puzzle
    public GameObject maisReputacao; //texto "+ Reputação"
    public GameObject icone; // icone de puzzle
    private float aumentoReputacao = 10f; // o quanto a reputação aumenta
    public Slider barraReputacao; // slider da reputação
   public void ContinueBnt() // batão de continue
    {
        var stopbullets = muzzle.GetComponent<Turret>(); //pega o script turret do muzzle

       
        icone.SetActive(false); //desativa icone
        canvasPuzzle.SetActive(false); //desativa canvas do puzzle
        triggerBox.SetActive(false); //desativa trigger do puzzle
        maisReputacao.SetActive(true); // ativa texto da reputação

        
        stopbullets.CancelInvoke(); // cancela o invoke das balas do hidrante
        Time.timeScale = 1f; //volta o tempo ao normal
        barraReputacao.value = Mathf.Clamp(barraReputacao.value + aumentoReputacao, 0, barraReputacao.maxValue); //aumenta a barra da reputação

        

        
    }
    
}
