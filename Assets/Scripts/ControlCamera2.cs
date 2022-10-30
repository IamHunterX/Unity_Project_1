using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cam1;
    public GameObject cam2;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Player2CamKey1")){
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        if(Input.GetButtonDown("Player2CamKey2")){
            cam1.SetActive(false);
            cam2.SetActive(true);
        }

    }
}
