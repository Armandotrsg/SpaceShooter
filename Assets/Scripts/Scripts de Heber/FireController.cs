using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    [SerializeField] private Transform shoot;
    [SerializeField] private GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot(){
        Instantiate(bullet, shoot.position, shoot.rotation);
    }
}
