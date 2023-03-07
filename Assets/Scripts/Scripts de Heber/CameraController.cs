using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float maxY;
    public float minY;
    public float speedY;
    float movementY;

    public float maxX;
    public float minX;
    public float speedX;
    float movementX;

    void Update()
    {
        movementY = Input.GetAxis("Vertical");

        if(movementY != 0){
            transform.Translate(0, movementY * Time.deltaTime * speedY, 0);
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
        }
    }
}
