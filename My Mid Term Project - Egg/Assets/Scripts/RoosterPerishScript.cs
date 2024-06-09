using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoosterPerishScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("death", 40f);
    }

    // Update is called once per frame
    private void death()
    {
        Destroy(gameObject);
    }
}
