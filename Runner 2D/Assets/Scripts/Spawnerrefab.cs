using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerrefab : MonoBehaviour
{
    private Vector3 nextposition;
    public GameObject @object;
    public Transform spawnlocation;

    private void Start()
    {
        nextposition = spawnlocation.position;
        InvokeRepeating("Create", 1, 1);
    }
    void Create()
    {
        GameObject spawnedObject = Instantiate(@object, nextposition, spawnlocation.rotation);
        nextposition += new Vector3(19.6f, 0f, 0f);
    }
}
