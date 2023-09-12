using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Hero player;
    Vector3 lastposition;
    float distanceTomove;
    private void Start()
    {
        player = FindObjectOfType<Hero>();
        lastposition = player.transform.position;
    }
    private void Update()
    {
        distanceTomove = player.transform.position.x - lastposition.x;
        transform.position = new Vector3(transform.position.x + distanceTomove, transform.position.y, transform.position.z);
        lastposition = player.transform.position;
    }
}
