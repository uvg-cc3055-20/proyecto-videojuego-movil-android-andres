using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
 * 
 * @Author: Andres Quan 17652
 * 
 */

public class GameController : MonoBehaviour {

    //Variable that allows other classes to access internal functioning
    public static GameController instance;

    //Variable that sets up the score
    public int score = 0;

    //Game Over variable
    public bool gameOver = false;

    //Allows to change the score on screen
    public Text textScore;
    
	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Method used by other classes to kill the player
    void playerDied()
    {
        gameOver = true;
    }
}
