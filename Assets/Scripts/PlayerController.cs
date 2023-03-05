using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    [SerializeField]
    private float minY, maxY, minX, maxX, speed;

    [SerializeField]
    private Proyectil proyectil;

    private float coolDown = 0.5f;

    void Start() {
        
    }

    /// <summary>
    ///     Moves the player and makes sure it doesn't go out of bounds
    /// </summary>
    void MovePlayer() {
        //Get the horizontal and vertical input of the user.
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Check if the player is out of bounds
        if (transform.position.y > maxY && vertical > 0) {
            vertical = 0;
        } else if (transform.position.y < minY && vertical < 0) {
            vertical = 0;
        }

        if (transform.position.x > maxX && horizontal > 0) {
            horizontal = 0;
        }else if (transform.position.x < minX && horizontal < 0) {
            horizontal = 0;
        }

        //Move the player
        transform.Translate(new Vector3(horizontal, vertical, 0) * Time.deltaTime * speed, Space.World);
    }

    /// <summary>
    ///     Shoots a proyectil
    /// </summary>
    void Shoot() {
        //Create a new variable called pos, which will hold the current position of the player.
        Vector3 pos = transform.position;
        //Create a new variable called rotation, which will hold the current rotation of the player.
        Quaternion rotation = transform.rotation;
        //Set the x-axis and y-axis rotations of the rotation variable to 0 and add 90 to the z axis rotation.
        rotation.eulerAngles = new Vector3(0, 0, 90);
        //Add 0.5 to the x-axis position, to make sure the bullet spawns in front of the player.
        pos.x += 0.5f;
        //Spawn the bullet, with the position and rotation variables as parameters.
        Instantiate(proyectil, pos, rotation);
    }

    // Update is called once per frame
    void Update() {
        // Move the player
        MovePlayer();
        // Check if the player is shooting and if the cooldown is less than or equal to 0
        if (Input.GetButtonDown("Fire1") && coolDown <= 0) {
            // Shoot the player's weapon
            Shoot();
            // Set the cooldown to 0.5 seconds
            coolDown = 0.5f;
        } else { // If the cooldown is greater than 0
            // Reduce the cooldown by the time since the last update
            coolDown -= Time.deltaTime;
        }
    }
}
