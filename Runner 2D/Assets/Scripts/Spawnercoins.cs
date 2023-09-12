using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnercoins : MonoBehaviour
{
     private Vector3 nextposition;
    public Transform spawnlocation;
    public GameObject game;


    private void Start()
    {
        nextposition = spawnlocation.position;
        InvokeRepeating("Create", 1, 1); 
    }

    private void Create()
    {
        GameObject spawnedObject = Instantiate(game, nextposition, spawnlocation.rotation);
        nextposition += new Vector3(30f, 0f, 0f);
    }
}
