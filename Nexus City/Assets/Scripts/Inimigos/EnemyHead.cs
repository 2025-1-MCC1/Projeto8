using UnityEngine;

public class EnemyHead : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "Player") // verifica colisão com player
        {
            var enemy = transform.parent.gameObject; //cria variavel enemy e faz com que ela pegue o parent
            enemy.SetActive(false);//desativa inimigo
            Start();
        }
       
    }
       
}
