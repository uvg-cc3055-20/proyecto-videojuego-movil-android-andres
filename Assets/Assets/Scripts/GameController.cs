using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public static GameController instance;
    public int score = 0;
    public bool gameOver = false;
    public Text textScore;
    
	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void playerDied()
    {
        gameOver = true;
    }
}
