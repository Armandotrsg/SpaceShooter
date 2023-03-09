using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilEnemigo : MonoBehaviour
{
    //variables del disparo
    [SerializeField]private float speed = 4f;
    [SerializeField] private float damage;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f); // Destroy the bullet after 5 seconds
    }

    // Update is called once per frame
    void Update()
    {
        //y = -1 porque tiene que ir para abajo
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed, Space.World); // Move the bullet
    }

    // void OnTriggerEnter(Collider other)
    // {
    //     if(other.CompareTag("Player")){
    //         other.GetComponent<Player>().Damage(damage);
    //         Destroy(gameObject);
    //     }
    // }
}
