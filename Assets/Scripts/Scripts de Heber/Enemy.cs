using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    [SerializeField] private float live;
    [SerializeField] private GameObject dead;   

    void Start()
    {
        Destroy(gameObject, 5);
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
}