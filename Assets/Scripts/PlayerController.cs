using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    [SerializeField]
    private float minY, maxY, minX, maxX, speed;

    [SerializeField]
    private Proyectil proyectil;

    Coroutine currentCoroutine;

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
        //Create a new variable called pos, which will hold the currentCoroutine position of the player.
        Vector3 pos = transform.position;
        //Create a new variable called rotation, which will hold the currentCoroutine rotation of the player.
        Quaternion rotation = transform.rotation;
        //Set the x-axis and y-axis rotations of the rotation variable to 0 and add 90 to the z axis rotation.
        rotation.eulerAngles = new Vector3(0, 0, 0);
        //Add 0.5 to the x-axis position, to make sure the bullet spawns in front of the player.
        pos.y += 0.5f;
        //Spawn the bullet, with the position and rotation variables as parameters.
        Instantiate(proyectil, pos, rotation);
    }

    // Update is called once per frame
    void Update() {
        // Move the player
        MovePlayer();
        // Check if the player is shooting and if the cooldown is less than or equal to 0
        if ((Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))) {
            // Start the delay coroutine
            currentCoroutine = StartCoroutine(Delay());
        }

        if (Input.GetButtonUp("Fire1") || Input.GetButtonUp("Jump")) {
            // Stop the delay coroutine
            StopCoroutine(currentCoroutine);
        }
    }

    IEnumerator Delay() {
        while (true) {
            Shoot();
            yield return new WaitForSeconds(0.5f);
        }
    }

    // IEnumerator CoolDown() {
    //     yield return new WaitForSeconds(0.5f);
    // }
}
