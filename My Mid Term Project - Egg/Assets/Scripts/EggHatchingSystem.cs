using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class EggHatchingSystem : MonoBehaviour
{
    public GameObject chick;
    private Transform localTransform;
    // Start is called before the first frame update
    void Start()
    {
        localTransform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
     
        Invoke("hatch", 10f);
    }

        
    private void hatch()
    { 
        Instantiate(chick, localTransform.position, localTransform.rotation);
        Destroy(gameObject);
    }
}
