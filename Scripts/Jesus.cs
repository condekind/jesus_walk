using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jesus : MonoBehaviour {
    private Animator animator;
    private bool jumping = false;

    private bool sliding = false;
    private float slidingTime = 0.0f;

    public GameObject explosion;
    public GameObject haloShot;
    // Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void jump()
    {
        if (!jumping)
        {
            jumping = true;
            animator.SetBool("Running", false);
            Vector2 jumpForceUp = new Vector2 (0.0f, 11.3f);
			this.GetComponent<Rigidbody2D> ().AddForce (jumpForceUp, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            jumping = false;
            animator.SetBool("Running", true);
        }

        if (collision.gameObject.tag == "Seagull")
        {
            Vector3 pos = new Vector3(collision.gameObject.GetComponent<Rigidbody2D>().position.x + Random.Range(-1.5f, 0.5f), GetComponent<Rigidbody2D>().position.y + Random.Range(-0.5f, 0.5f), -2.0f);
            Instantiate(explosion, pos, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
    public void slide()
    {
        if (!sliding)
        {
            sliding = true;
            animator.SetBool("Running", true);
            animator.SetBool("Sliding", true);
            Invoke("stopSlide", 1.5f);
        }
    }
    private void stopSlide()
    {
        animator.SetBool("Sliding", false);
        animator.SetBool("Running", true);
        sliding = false;
        CancelInvoke("stopSlide");
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Shark")
        {
            Vector3 pos = new Vector3(collider.gameObject.GetComponent<Rigidbody2D>().position.x + Random.Range(-1.5f, 0.5f), GetComponent<Rigidbody2D>().position.y + Random.Range(-0.5f, 0.5f), -2.0f);
            Instantiate(explosion, pos, Quaternion.identity);
            Destroy(collider.gameObject);
        }
    }

    public void shotHalo()
    {
        Instantiate(haloShot, GetComponent<Rigidbody2D>().position, Quaternion.identity);
    }

}
