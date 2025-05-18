using UnityEngine;

public class Turret : MonoBehaviour
{

    public GameObject bullet;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Shoot", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Shoot()
    {
        var Muzzle = gameObject.transform;

        Instantiate(bullet, Muzzle.position, Muzzle.rotation);
    }
}
