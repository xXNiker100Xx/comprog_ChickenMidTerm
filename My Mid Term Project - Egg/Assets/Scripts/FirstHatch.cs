using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstHatch : MonoBehaviour
{
    public GameObject Hen;
    void Start()
    {
        Invoke("spawnHen", 10f);
    }
    private void spawnHen()
    {
        Instantiate(Hen, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
