using UnityEngine;

public class Turret : MonoBehaviour
{

    public GameObject bullet;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Shoot", 1f, 1f); // invoca os tiros repetidamente
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Shoot()
    {
        var Muzzle = gameObject.transform; // pega o transform do objeto

        Instantiate(bullet, Muzzle.position, Muzzle.rotation); // cria bala na mesma posição e rotação que o objeto
    }
}
