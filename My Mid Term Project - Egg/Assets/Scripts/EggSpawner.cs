using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject egg;
    public GameObject hen;
    public Transform eggSpawn;

    private void Start()
    {
        InvokeRepeating("spawnEgg", 30f, 30f);
        Invoke("killHen", 40f);
    }

    private void spawnEgg()
    {
        int randomEggs;
        randomEggs = Random.Range(2, 10);

        for (int i = 0; i < randomEggs; i++)
        {
            GameObject eggs = Instantiate(egg, eggSpawn.transform.position, eggSpawn.rotation);
            eggs.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, -250));
        }
    }

    private void killHen()
    {
        Destroy(hen);
    }

    

}
