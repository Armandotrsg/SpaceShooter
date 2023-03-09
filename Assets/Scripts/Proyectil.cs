using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour {

    private ScoreGUI _scoreGUI;

    private PlayerController player;
    [SerializeField]private float speed = 2f;
    [SerializeField] private float damage;
    void Start()
    {
        _scoreGUI = ScoreGUI.Instance;
        player = PlayerController.Instance;
        Destroy(gameObject, 5f); // Destroy the bullet after 5 seconds
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed, Space.World); // Move the bullet
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy")){
            other.GetComponent<Enemy>().Damage(damage);
            Destroy(gameObject);
            player.Score += 10;
            _scoreGUI._texto.text = "Score: " + player.Score;
        }
    }
}
