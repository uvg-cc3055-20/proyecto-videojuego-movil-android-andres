using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * 
 * @Author: Andres Quan 17652
 * 
 */

public class Player : MonoBehaviour {
    
    //RigidBody2D variable
    public Rigidbody2D rb;

    //Checks if the player is on the ground
    public Transform groundCheck;

    //Radius for the check
    public float groundCheckRadius;

    //Pointer
    public LayerMask whatIsGround;

    //Bool value to point that the player is on the ground
    private bool onGround;

    //Score value
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
        //Two posible collisions: Enemy and ground.
        //End game procedure.
        if(collision.gameObject.tag == "Enemy")
        {
            rb.transform.position = new Vector2(-2, 2);
            GameController.instance.gameOver = true;
            gameOver();
        }

        //Changes the score
        score = GameController.instance.score;
        GameController.instance.score++;
        GameController.instance.textScore.text = string.Concat("Score: " + score);
        
    }

    //Trigger for platform destroyer
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Eraser")
        {
            Destroy(gameObject);
        }
    }

    //game over vectorial velocity change
    void gameOver() => rb.velocity = new Vector2(rb.velocity.y, 500);
}
