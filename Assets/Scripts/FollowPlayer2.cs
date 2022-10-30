using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject camera2;
    private Vector3 offset =  new Vector3(0,5,-9);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = camera2.transform.position + offset;
    }
}
