using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xRange = 20;
    private float spwanZ = 20;
    private float timeDelay = 2;
    private float timeRepeat = 1.5f;
    
    //[] array is used to store multiple variables or multiple object;
    // Start is called before the first frame update
    void Start()
    {// invoke rpeating method is used to spawn a object automatically with time intrevals
        InvokeRepeating("SpawnRandomAnimal", timeDelay, timeRepeat);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }

    }
    
    //we create a new method and it can be used by recalling the method in the function
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-xRange, xRange), 0, spwanZ);
        
        Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
    }

}
