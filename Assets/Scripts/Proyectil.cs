using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour {
    [SerializeField]
    private float speed = 2f;
    void Start()
    {
        Destroy(gameObject, 5f); // Destroy the bullet after 5 seconds
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed, Space.World); // Move the bullet
    }
}
