using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameobject : MonoBehaviour
{
    public GameObject DestroyPoint;


    private void Start()
    {
        DestroyPoint =GameObject.Find("DestroyPoint");
    }

    private void Update()
    {
        if(transform.position.x < DestroyPoint.transform.position.x)
        {
            Destroy(gameObject);
        } 
    }
}
