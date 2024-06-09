using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class cameraRotation : MonoBehaviour
{
    Transform pivot;
    public Transform Camera;
    public float speedRotation = 20f;
    
    
    void Start()
    {
        pivot = GetComponent<Transform>();
        
    }
    void Update()
    {
        
        float rotationAmount = speedRotation * Time.deltaTime;
 
        Quaternion rotation = Quaternion.Euler(0, rotationAmount, 0);

        pivot.rotation *= rotation;
    }
}



