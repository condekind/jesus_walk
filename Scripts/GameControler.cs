using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour {
    private int points = 0;

    private Text pointText;
    private Text recordText;
    private GameObject restartGame;

    public GameObject ghosts;
	// Use this for initialization
	void Start () {
	pointText = (Text) GameObject.Find("PointText").GetComponent<Text>();
        restartGame = GameObject.Find("RestartButton");
        restartGame.gameObject.SetActive(false);

        recordText = (Text)GameObject.Find("RecordText").GetComponent<Text>();
        recordText.text = "Record: " + PlayerPrefs.GetInt("Record");
        recordText.gameObject.SetActive(false);

        ghosts = GameObject.Find("Ghosts");
        ghosts.gameObject.SetActive(false);
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
        ghosts.SetActive(true);
    }

    public void finallyRestart()
    {
        SceneManager.LoadScene("Scene1");
    }

    public int getPoints()
    {
        return points;
    }
    //Call this when you die
    public void killmePlease()
    {
        if(PlayerPrefs.GetInt("Record")<points)
            PlayerPrefs.SetInt("Record", points);

        recordText.gameObject.SetActive(true);
        recordText.text = "Record: " + PlayerPrefs.GetInt("Record");
    }
}
