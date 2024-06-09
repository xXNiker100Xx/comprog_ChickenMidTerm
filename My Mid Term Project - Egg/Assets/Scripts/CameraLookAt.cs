using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform cameraTransform;
    public Transform objectTransform;
    public float rotation = -90;
    

    // Start is called before the first frame update
    private void Start()
    {
        objectTransform = GetComponent<Transform>();
       
        Camera camera = FindAnyObjectByType<Camera>();
        if (camera != null)
        {
            print("camera is true!");
            cameraTransform = camera.transform;

        }
    }

    void FixedUpdate()
    {
        lookAtCamera();
    }
    void lookAtCamera()
    {
        Vector3 relativePos = cameraTransform.position - objectTransform.position;
        objectTransform.rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        objectTransform.Rotate(Vector3.up, rotation);

    }
}
