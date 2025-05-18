using UnityEngine;

public class TriggerCanos1 : MonoBehaviour
{
    public GameObject PuzzleCanos1;
    public GameObject Canvas1;
    public GameObject Win1;

    private bool PlayerTrigger = false;

    void Start()
    {
        PuzzleCanos1.gameObject.SetActive(false);
        Canvas1.gameObject.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && PlayerTrigger)
        {
            Canvas1.SetActive(false);
            PuzzleCanos1.SetActive(true);
            Win1.SetActive(false);
            Time.timeScale = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Canvas1.SetActive(true);
            PlayerTrigger = true;
        }

       

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Canvas1.SetActive(false);
            PlayerTrigger = false;
        }
    }
}
