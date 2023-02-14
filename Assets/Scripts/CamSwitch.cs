using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject camera1;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            MainCamera.SetActive(true);
            camera1.SetActive(false);
           
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            MainCamera.SetActive(false);
            camera1.SetActive(true);
            
        }
       
    }
}
