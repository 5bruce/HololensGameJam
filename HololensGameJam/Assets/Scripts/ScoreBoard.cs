using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour {
    private TextMesh scoreText;
    int scoreCounter;
	// Use this for initialization
	void Start () {
        scoreCounter = 0;
        scoreText = gameObject.GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void increment()
    {
        scoreCounter++;
        scoreText.text = scoreCounter.ToString();
    }
}
