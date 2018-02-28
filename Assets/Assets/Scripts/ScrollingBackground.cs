using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*
 * 
 * @Author: Andres Quan 17652
 * 
 */
public class ScrollingBackground : MonoBehaviour {
    //Variable that allows the access to variables by other classes
    public static ScrollingBackground instance;

    //Scrolling speed of the background
    public float scrollingSpeed;

    //Allows the Body to be affected by physics by signaling that is this one
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        scrollingSpeed = 4f;	
	}

    // Update is called once per frame
    void Update() {

        //Acceleration-per-update of the scrolling speed of the background.
        scrollingSpeed += 1f * Time.deltaTime;

        //Transformation of the background itself
        transform.Translate(Vector2.left * scrollingSpeed * Time.deltaTime);

        //reset of the background's position
        if(transform.position.x < -15.5)
        {
            transform.position = new Vector3(100.0f, transform.position.y, transform.position.z);
        }
	}
}
