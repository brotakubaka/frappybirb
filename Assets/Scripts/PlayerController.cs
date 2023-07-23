using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private GameManager gameManager;
    public float flapStrength;
    private float lowerBound = -20;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            playerRb.velocity = Vector2.up * flapStrength;
        }

        if(transform.position.y < lowerBound)
        {
            gameManager.isGameOver = true;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.AddScore(1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.isGameOver = true;
    }
}
