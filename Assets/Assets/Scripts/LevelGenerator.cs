using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * 
 * @Author: Andres Quan 17652
 * 
 */

public class LevelGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Regenerate();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Method to generate platforms
    public void Regenerate()
    {
       // Instantiate(Platform, new Vector2(-2, 1), gameObject.transform.rotation);
    }
}
