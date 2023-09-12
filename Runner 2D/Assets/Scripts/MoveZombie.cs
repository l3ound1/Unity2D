using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZombie : MonoBehaviour
{
    public float speed = 5f; 
    public float timer = 3f;


    private void Start()
    {
        timer = 3f;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            speed += 0.5f;
            timer = 3f;
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
