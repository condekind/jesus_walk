using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour {
    private int points = 0;

    private Text pointText;
    private GameObject restartGame;
	// Use this for initialization
	void Start () {
	pointText = (Text) GameObject.Find("PointText").GetComponent<Text>();
        restartGame = GameObject.Find("RestartButton");
        restartGame.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void addPoint(int num)
    {
        points += num;
        pointText.text = "Points: " + points;
    }
    public void restart()
    {
        //Do what ever you want before retarting
        restartGame.SetActive(true);
    }

    public void finallyRestart()
    {
        SceneManager.LoadScene("Scene1");
    }
}
