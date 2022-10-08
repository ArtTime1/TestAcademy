using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs;   
    private int randomPrefab;
    
    void Update()
    {      
        SpawnPrefab();      
    }
    
    private void SpawnPrefab()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomPrefab = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[randomPrefab], transform.position, Quaternion.identity);
        }
    }  
}
