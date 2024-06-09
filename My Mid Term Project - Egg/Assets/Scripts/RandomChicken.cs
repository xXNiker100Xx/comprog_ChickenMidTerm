using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomChicken : MonoBehaviour
{
    public GameObject[] ChickenType;
    public int randomChicken;
    
    private void Start()
    {
        
        randomChicken = Random.Range(0, ChickenType.Length);
        Invoke("chickenType", 10f);
    }

    private void chickenType() 
    {
       
        if (randomChicken >= 0 && randomChicken < ChickenType.Length)
        {
            GameObject newChicken = Instantiate(ChickenType[randomChicken], transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
     
    }  
}
