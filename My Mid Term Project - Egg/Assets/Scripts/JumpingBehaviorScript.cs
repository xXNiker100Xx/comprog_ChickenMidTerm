using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingBehaviorScript : MonoBehaviour
{
    Rigidbody rb;
    float jumpTimer = 0f;
    public float jumpHeight;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpHeight = Random.Range(2,5);
    }

    private void Update()
    {
        jumpTimer += Time.deltaTime;

        if( jumpTimer >= 2f )
        {
            jumpTimer = 0;
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            
        }

       
    }
}
