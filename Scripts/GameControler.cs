using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour {
    private int points = 0;

    private Text pointText;
	// Use this for initialization
	void Start () {
	pointText = (Text) GameObject.Find("PointText").GetComponent<Text>();;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void addPoint(int num)
    {
        points += num;
        pointText.text = "Points: " + points;
    }
}
