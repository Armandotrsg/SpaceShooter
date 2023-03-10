using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    private Coroutine _corrutina;

    [SerializeField] 
    private float live;

    [SerializeField] 
    private GameObject dead;   

    [SerializeField]
    private ProyectilEnemigo proyectil;

    void Start()
    {
        Destroy(gameObject, 5);
        _corrutina = StartCoroutine(DisparoRecurrente());
    }

    public void Damage(float damage)
    {
        live = live - damage;
        if(live <= 0)
        {
            Dead();
        }
    }

    private void Dead()
    {
        Destroy(gameObject);
    }

    IEnumerator DisparoRecurrente()
    {
        while(true)
        {
            //se pueden hacer gameobjects vacios
            //Gameobject objeto = new GameObject();

            //si queremos un gameo predefinido para clonar
            //usamos instantiate
            Instantiate(
                proyectil,
                transform.position,
                transform.rotation);
            
            yield return new WaitForSeconds(0.8f);
            print("corrutina recurrente");

            
        }
    }
}