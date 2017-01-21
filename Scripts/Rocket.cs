using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    public GameObject explosion; 
	// Use this for initialization
	void Start () {
		Vector2 jumpForceUp = new Vector2(-10.0f, 0);
        this.GetComponent<Rigidbody2D>().AddForce(jumpForceUp, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Halo")
        {
            Vector3 pos = new Vector3(collision.gameObject.GetComponent<Rigidbody2D>().position.x + Random.Range(-1.5f, 0.5f), GetComponent<Rigidbody2D>().position.y + Random.Range(-0.5f, 0.5f), -2.0f);
            Instantiate(explosion, pos, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            
        }
    }
}
