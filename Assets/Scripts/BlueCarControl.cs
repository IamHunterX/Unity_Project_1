using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCarControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedOfBlueCar=4.0f ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speedOfBlueCar);
    }
}
