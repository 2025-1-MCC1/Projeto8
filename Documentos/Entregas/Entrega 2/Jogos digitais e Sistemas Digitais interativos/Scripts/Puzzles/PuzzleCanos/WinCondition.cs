using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    public bool d90 = false; // 90 graus
    public bool d90n = false; //-90 graus
    public bool d9090 = false; // 90 e -90 graus
    public bool d180 = false; // 180 graus 
    public bool d0 = false; // 0 graus
    public bool d1800 = false; //180 e 0 graus
    public bool won = false; // vitoria

    public GameObject Puzzle1; // canvas do puzzle
    public GameObject Win1; // canvas de vitoria

    void Start()
    {
        Win1.SetActive(false); // desativa canvas de vitora
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject[] tag90 = GameObject.FindGameObjectsWithTag("90d"); //acha todos os objetos com a tag "90d" e poe eles numa lista
        GameObject[] tag90n = GameObject.FindGameObjectsWithTag("90dn"); //acha todos os objetos com a tag "90dn" e poe eles numa lista
        GameObject[] tag9090 = GameObject.FindGameObjectsWithTag("90d90dn"); //acha todos os objetos com a tag "90d90d" e poe eles numa lista
        GameObject[] tag180 = GameObject.FindGameObjectsWithTag("180d"); //acha todos os objetos com a tag "180d" e poe eles numa lista
        GameObject[] tag0 = GameObject.FindGameObjectsWithTag("0d"); //acha todos os objetos com a tag "0d" e poe eles numa lista
        GameObject[] tag1800 = GameObject.FindGameObjectsWithTag("180d0d"); //acha todos os objetos com a tag "180d0d" e poe eles numa lista


        // todas as lista para true
        d90 = true;
        d90n = true;
        d9090 = true;
        d180 = true;
        d0 = true;
        d1800 = true;
        

        //90 graus
        foreach (GameObject obj in tag90) // para cada objeto na lista
        {
            float zRotation = obj.transform.eulerAngles.z; //cria float que contem a rotação do objeto

            if (Mathf.Abs(Mathf.DeltaAngle(zRotation, 90f)) > 0.1f) //se objeto não estiver rotacionado em 90 graus
            {
                d90 = false; // desativa lista
                break;
            }

            
        }

        // - 90 graus
        foreach (GameObject obj in tag90n) 
        {
            float zRotation = obj.transform.eulerAngles.z;

            if (Mathf.Abs(Mathf.DeltaAngle(zRotation, -90f)) > 0.1f) //se objeto não estiver rotacionado em -90 graus
            {
                d90n = false;
                break;
            }


        }

        // 90 e - 90 graus
        foreach (GameObject obj in tag9090)
        {
            float zRotation = obj.transform.eulerAngles.z;

            bool bd90 = Mathf.Abs(Mathf.DeltaAngle(zRotation, 90f)) <= 0.1f; 
            bool bd90n = Mathf.Abs(Mathf.DeltaAngle(zRotation, -90f)) <= 0.1f;

            if (!bd90 && !bd90n) //se objeto não estiver rotacionado em 90 graus ou em -90 graus
            {
                d9090 = false;
                break;
            }


        }

        // 180 graus
        foreach (GameObject obj in tag180)
        {
            float zRotation = obj.transform.eulerAngles.z;

            if (Mathf.Abs(Mathf.DeltaAngle(zRotation, 180f)) > 0.1f) //se objeto não estiver rotacionado em 180 graus
            {
                d180 = false;
                break;
            }


        }

        // 0 graus
        foreach (GameObject obj in tag0)
        {
            float zRotation = obj.transform.eulerAngles.z;

            if (Mathf.Abs(Mathf.DeltaAngle(zRotation, 0f)) > 0.1f) //se objeto não estiver rotacionado em 0graus
            {
                d0 = false;
                break;
            }


        }

        //180 e 0 graus
        foreach (GameObject obj in tag1800)
        {
            float zRotation = obj.transform.eulerAngles.z;

            bool bd0 = Mathf.Abs(Mathf.DeltaAngle(zRotation, 0f)) <= 0.1f;
            bool bd180 = Mathf.Abs(Mathf.DeltaAngle(zRotation, 180f)) <= 0.1f;

            if (!bd0 && !bd180) //se objeto não estiver rotacionado em 90 graus ou em 180 graus
            {
                d1800 = false;
                break;
            }


        }

        if (d90 && d90n && d9090 && d180 && d0 && d1800 == true) // se todas as listas forem true...
        {
           won = true; // won tambem é true
        }

        if (won) // se won for true
        {
            Puzzle1.SetActive(false); // desativa canvas do puzzle
            Win1.SetActive(true); // ativa canvas de vitoria

        }

        

    }
}
