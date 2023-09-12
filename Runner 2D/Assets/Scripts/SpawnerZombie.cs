using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnerZombie : MonoBehaviour
{
    private Vector3 nextposition;
    public GameObject[] @object;
    public Transform spawnlocation;
    public GameObject hero;
    
    private void Start()
    {
       
        nextposition = spawnlocation.position;

        InvokeRepeating("Create", 1, 1);
    }
    void Create()
    {
        int randoindex  = Random.Range(0,@object.Length);
        
        GameObject spawnedObject = Instantiate(@object[randoindex], nextposition, spawnlocation.rotation);
        nextposition += new Vector3(15f, 0f, 0f);


        if(hero == null)
        {
            Destroy(gameObject);
            Destroy(spawnedObject);
            
        }


        
        
    }
  
    
}
