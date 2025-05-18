using UnityEngine;
using UnityEngine.UI;



public class Continue : MonoBehaviour
{

    public GameObject muzzle;
    public GameObject triggerBox;
    public GameObject canvasPuzzle;
    public GameObject maisReputacao;
    public GameObject icone;
    private float aumentoReputacao = 10f;
    public Slider barraReputacao;
   public void ContinueBnt()
    {
        var stopbullets = muzzle.GetComponent<Turret>();

       
        icone.SetActive(false);
        canvasPuzzle.SetActive(false);
        triggerBox.SetActive(false);
        maisReputacao.SetActive(true);

        
        stopbullets.CancelInvoke();
        Time.timeScale = 1f;
        barraReputacao.value = Mathf.Clamp(barraReputacao.value + aumentoReputacao, 0, barraReputacao.maxValue);

        

        
    }
    
}
