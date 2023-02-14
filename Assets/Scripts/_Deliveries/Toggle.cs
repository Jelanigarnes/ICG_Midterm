using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    public List<Material> materials = new List<Material>();
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[0];
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[1];
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[2];
        }
    }
}
