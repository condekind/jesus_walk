using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerIntro : MonoBehaviour {
    public Text recordText;
	// Use this for initialization
	void Start () {
        if(PlayerPrefs.GetInt("Record")>=0)
        recordText.text = "Score: " + PlayerPrefs.GetInt("Record");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
