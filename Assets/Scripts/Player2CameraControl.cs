using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2CameraControl : MonoBehaviour
{
   // Start is called before the first frame update
    public GameObject camera;
    private Vector3 offset =  new Vector3(6,5,-9);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = camera.transform.position + offset;
    }
}
