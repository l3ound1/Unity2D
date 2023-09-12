using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZombieCamera : MonoBehaviour
{
    

    private void Update()
    {
        if (transform.position.x < -19f)
        {
            Destroy(gameObject);
        }

    }
}
