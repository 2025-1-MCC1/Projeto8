using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Collections;
using JetBrains.Annotations;
public class PassouDeFase : MonoBehaviour
{
   
    
    
        public string ProximaFase;
    private void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(ProximaFase);
    }
}

