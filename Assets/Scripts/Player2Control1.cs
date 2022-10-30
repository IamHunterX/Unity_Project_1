using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Control1 : MonoBehaviour
{
   // private variables
    private float speed = 10.0f;
    private float turnSpeed = 20.0f;
    private float horizontalInput;
    private float forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
           Debug.Log("Going, going, Gone........!");
    }

    // Update is called once per frame
    void Update()
    {
        //Getting Input
        forwardInput = Input.GetAxis("Vertical1");
        horizontalInput = Input.GetAxis("Horizontal1");

        //Moves the car forward depending upon Vertical Input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotates the car depending upon horizontal input
        transform.Rotate(Vector3.up,Time.deltaTime * turnSpeed * horizontalInput);
    }
}
