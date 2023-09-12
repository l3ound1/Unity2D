using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject panel;
    public float speed = 5f;
    public float jump = 5.5f;
    private Material matBlink;
    private Material matDefault;
    private SpriteRenderer spriteRenderer;
    public float timer = 3f;
    public int lives = 3;
    public int numolives;
    public Image[] images;
    public Sprite fulllives;
    public Sprite oflives;
    private Scoremenegar gameManager;




    private void Start()
    {
        timer = 3f;
    }

    private void Awake()
    {
        gameManager = FindObjectOfType<Scoremenegar>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        matBlink = Resources.Load("EnemyBlink", typeof(Material)) as Material;
        matDefault = spriteRenderer.material;
    }

    private void Update()
    {
        if (lives <= 0)
        {
            panel.SetActive(true);
            Destroy(gameObject);


        }
        if (lives > numolives)
        {
            lives = numolives;
        }
        for (int i = 0; i < images.Length; i++)
        {
            if (i < Mathf.RoundToInt(lives))
            {
                images[i].enabled = fulllives;
            }
            else
            {
                images[i].sprite = oflives;
            }
            if (i < numolives)
            {
                images[i].enabled = true;
            }
            else
            {
                images[i].enabled = false;
            }
        }

        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            speed += 0.5f;
            timer = 3f;
        }
        rb.velocity = new Vector2(speed, rb.velocity.y);


    }
    public void Jump()
    {

        if (Mathf.Abs(rb.velocity.y) < 0.0005f)
        {
            rb.AddForce(transform.up * jump, ForceMode2D.Impulse);
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            loselife();
            spriteRenderer.material = matBlink;
            Invoke("ResetMaterial", 0.2f);
        }
    }
    void ResetMaterial()
    {
        spriteRenderer.material = matDefault;
    }


    private void loselife()
    {
        lives -= 1;
    }
    public void Die()
    {
        gameManager.IncreaseScore();
    }
}
