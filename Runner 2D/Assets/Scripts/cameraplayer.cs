using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraplayer : MonoBehaviour
{
    private void Start()
    {
       
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(screenWidth / 2, screenHeight / 2, 0));

       
        transform.position = new Vector3(worldPosition.x, worldPosition.y, transform.position.z);
    }
   
}
