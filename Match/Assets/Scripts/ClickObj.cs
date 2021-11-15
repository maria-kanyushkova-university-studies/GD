using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObj : MonoBehaviour
{
   public GameObject rb3D; 
    void OnMouseUp() 
    {
        rb3D = GetComponent<RigidBody3D>();
    }

    void Start()
    {
        rb3D = GetComponent<RigidBody3D>();
    }

    void Update()
    {
        
    }
}
