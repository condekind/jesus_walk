using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour {
    public GameObject explosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 jumpForceUp = new Vector2 (-0.2f, 0);
		this.GetComponent<Rigidbody2D> ().AddForce (jumpForceUp, ForceMode2D.Impulse);
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Vector3 pos = new Vector3(GetComponent<Rigidbody2D>().position.x + Random.Range(-1.5f, 0.5f), GetComponent<Rigidbody2D>().position.y + Random.Range(-0.5f, 0.5f), -2.0f);
            Instantiate(explosion, pos, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
