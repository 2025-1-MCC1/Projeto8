using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public static bool isGreen = false;

    public GameObject redLightObj;
    public GameObject greenLightObj;

    public void FixSignal()
    {
        isGreen = true;
        UpdateLights();
        Debug.Log("Sinal ficou verde!");
    }

    void Start()
    {
        UpdateLights(); // Atualiza no início
    }

    void UpdateLights()
    {
        redLightObj.SetActive(!isGreen);
        greenLightObj.SetActive(isGreen);
    }
}