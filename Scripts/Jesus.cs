using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jesus : MonoBehaviour {
    private Animator animator;
    private bool jumping = false;

    private bool sliding = false;
    private float slidingTime = 0.0f;

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
            jumping = false;
            animator.SetBool("Running", true);
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
}
