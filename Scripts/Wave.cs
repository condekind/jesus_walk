using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 jumpForceUp = new Vector2(-5.0f, 0.0f);
        this.GetComponent<Rigidbody2D>().AddForce(jumpForceUp, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
