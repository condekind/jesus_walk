using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bible : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector2 jumpForceUp;
        if (Random.Range(0, 2) >= 1)
            jumpForceUp = new Vector2(-14.0f, 0.2f);
        else
            jumpForceUp = new Vector2(-14.0f, 1.1f);
		this.GetComponent<Rigidbody2D> ().AddForce (jumpForceUp, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.x < -19 || gameObject.transform.position.x > 19)
        {
            Destroy(gameObject);
        }
	}
}
