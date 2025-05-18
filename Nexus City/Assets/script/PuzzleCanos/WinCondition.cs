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
    public bool won = false;

    public GameObject Puzzle1;
    public GameObject Win1;

    void Start()
    {
        Win1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //90 graus
        GameObject[] tag90 = GameObject.FindGameObjectsWithTag("90d");
        GameObject[] tag90n = GameObject.FindGameObjectsWithTag("90dn");
        GameObject[] tag9090 = GameObject.FindGameObjectsWithTag("90d90dn");
        GameObject[] tag180 = GameObject.FindGameObjectsWithTag("180d");
        GameObject[] tag0 = GameObject.FindGameObjectsWithTag("0d");
        GameObject[] tag1800 = GameObject.FindGameObjectsWithTag("180d0d");



        d90 = true;
        d90n = true;
        d9090 = true;
        d180 = true;
        d0 = true;
        d1800 = true;
        

        //90 graus
        foreach (GameObject obj in tag90) 
        {
            float zRotation = obj.transform.eulerAngles.z;

            if (Mathf.Abs(Mathf.DeltaAngle(zRotation, 90f)) > 0.1f)
            {
                d90 = false;
                break;
            }

            
        }

        // - 90 graus
        foreach (GameObject obj in tag90n)
        {
            float zRotation = obj.transform.eulerAngles.z;

            if (Mathf.Abs(Mathf.DeltaAngle(zRotation, -90f)) > 0.1f)
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

            if (!bd90 && !bd90n)
            {
                d9090 = false;
                break;
            }


        }

        // 180 graus
        foreach (GameObject obj in tag180)
        {
            float zRotation = obj.transform.eulerAngles.z;

            if (Mathf.Abs(Mathf.DeltaAngle(zRotation, 180f)) > 0.1f)
            {
                d180 = false;
                break;
            }


        }

        // 0 graus
        foreach (GameObject obj in tag0)
        {
            float zRotation = obj.transform.eulerAngles.z;

            if (Mathf.Abs(Mathf.DeltaAngle(zRotation, 0f)) > 0.1f)
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

            if (!bd0 && !bd180)
            {
                d1800 = false;
                break;
            }


        }

        if (d90 && d90n && d9090 && d180 && d0 && d1800 == true)
        {
           won = true;
        }

        if (won)
        {
            Puzzle1.SetActive(false);
            Win1.SetActive(true);

        }

        

    }
}
