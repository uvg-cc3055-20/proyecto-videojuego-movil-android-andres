using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

    public static ScrollingBackground instance;
    public float scrollingSpeed;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        scrollingSpeed = 4f;	
	}

    // Update is called once per frame
    void Update() {
        scrollingSpeed += 1f * Time.deltaTime;
        transform.Translate(Vector2.left * scrollingSpeed * Time.deltaTime);

        if(transform.position.x < -15.5)
        {
            transform.position = new Vector3(100.0f, transform.position.y, transform.position.z);
        }
	}
}
