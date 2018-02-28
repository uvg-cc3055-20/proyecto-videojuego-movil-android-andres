using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
    public Rigidbody2D rb;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
    public int score;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(20, rb.velocity.y);

        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        if(Input.GetMouseButtonDown(0)&& onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, (20));
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            rb.transform.position = new Vector2(-2, 2);
            GameController.instance.gameOver = true;
            gameOver();
        }

        score = GameController.instance.score;
        GameController.instance.score++;
        GameController.instance.textScore.text = string.Concat("Score: " + score);
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Eraser")
        {
            Destroy(gameObject);
        }
    }
    
    void gameOver()
    {
        rb.velocity = new Vector2(rb.velocity.y, 500);
    }
}
