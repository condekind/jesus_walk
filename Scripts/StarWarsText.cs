using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarWarsText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 jumpForceUp = new Vector2(0.0f, 0.6f);
        this.GetComponent<Rigidbody2D>().AddForce(jumpForceUp, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            Debug.Log("Inside");
            SceneManager.LoadScene("Scene1");
        }
    }
}
